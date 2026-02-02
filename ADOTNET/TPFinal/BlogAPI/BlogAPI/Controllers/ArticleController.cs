using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TPFinal.Class;
using TPFinal.Data;
using TPFinal.DTO;
using BlogConsole_BlogAPI.DTO;
using Microsoft.EntityFrameworkCore;

namespace TPFinal.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ArticleController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll([FromQuery] int? id, [FromQuery] string? title, [FromQuery] string? content, [FromQuery] string? creationDate)
        {
            var query = _context.Articles.AsQueryable();

            if (id != null && id >= 0)
            {
                query = query.Where(a => a.Id == id);
            }

            if (!string.IsNullOrEmpty(title))
            {
                query = query.Where(a => a.Title != null && a.Title.Contains(title));
            }

            if (!string.IsNullOrEmpty(content))
            {
                query = query.Where(a => a.Content != null && a.Content.Contains(content));
            }

            // Materialize before applying filters that cannot be translated to SQL (DateOnly.ToString())
            var articles = query.ToList();

            if (!string.IsNullOrEmpty(creationDate))
            {
                articles = articles.Where(a => a.CreationDate.ToString().Contains(creationDate)).ToList();
            }

            var result = articles
                .Select(article => new ArticleBasicInfoResponse()
                {
                    Id = article.Id,
                    Title = article.Title ?? string.Empty,
                    Content = article.Content ?? string.Empty,
                    CreationDate = article.CreationDate.ToString()
                })
                .ToList();

            return Ok(result);
        }

        // ---------------------------------------------------------------------------
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            // Charger l'article avec ses commentaires associés
            var articleFound = _context.Articles
                .Include(a => a.Comments)
                .FirstOrDefault(a => a.Id == id);

            if (articleFound == null)
                return NotFound();

            var dto = new ArticleDetailsResponse()
            {
                Id = articleFound.Id,
                Title = articleFound.Title ?? string.Empty,
                Content = articleFound.Content ?? string.Empty,
                CreationDate = articleFound.CreationDate.ToString(),
                ModifDate = articleFound.ModifDate.ToString(),
                Comments = articleFound.Comments
                    .Select(c => new CommentDetailsresponse
                    {
                        Id = c.Id,
                        ArticleId = c.ArticleId,
                        Author = c.Author,
                        Content = c.Content,
                        CreationDate = c.CreationDate.ToString()
                    })
                    .ToList()
            };

            return Ok(dto);
        }

        // ---------------------------------------------------------------------------
        [HttpPost]
        public IActionResult CreateArticle([FromBody] ArticleCreationRequest payload)
        {
            if (payload == null)
                return BadRequest(new { Message = "Payload is required." });

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var newArticle = new Article()
            {
                Title = payload.Title ?? string.Empty,
                Content = payload.Content ?? string.Empty,
                CreationDate = DateOnly.FromDateTime(DateTime.UtcNow)
            };

            _context.Articles.Add(newArticle);

            _context.SaveChanges();

            var responseDto = new ArticleDetailsResponse()
            {
                Id = newArticle.Id,
                Title = newArticle.Title,
                Content = newArticle.Content,
                CreationDate = newArticle.CreationDate.ToString(),
                ModifDate = newArticle.ModifDate.ToString()
            };

            return CreatedAtAction(nameof(GetById), new { id = newArticle.Id }, responseDto);
        }
        // ---------------------------------------------------------------------------
        [HttpPatch("{id}")]
        public IActionResult ModifyArticle(int id, [FromBody] ArticleModificationRequest payload)
        {
            var articleFound = _context.Articles.FirstOrDefault(a => a.Id == id);
            if (articleFound == null)
                return NotFound();
            if (payload.Title != null)
                articleFound.Title = payload.Title;
            if (payload.Content != null)
                articleFound.Content = payload.Content;
            articleFound.ModifDate = DateOnly.FromDateTime(DateTime.UtcNow);
            _context.SaveChanges();
            return NoContent();
        }
        // ---------------------------------------------------------------------------
        [HttpDelete("{id}")]
        public IActionResult DeleteArticle(int id)
        {
            var articleFound = _context.Articles.FirstOrDefault(a => a.Id == id);
            if (articleFound == null)
                return NotFound();
            _context.Articles.Remove(articleFound);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
