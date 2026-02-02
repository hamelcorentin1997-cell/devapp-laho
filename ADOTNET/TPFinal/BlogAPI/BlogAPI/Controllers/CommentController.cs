using System;
using System.Linq;
using System.Collections.Generic;
using BlogConsole_BlogAPI.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TPFinal.Class;
using TPFinal.Data;
using TPFinal.DTO;

namespace TPFinal.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CommentController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            var comments = _context.Comments.ToList();
            return Ok(comments);
        }
        // ---------------------------------------------------------------------------

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var comment = _context.Comments.Find(id);
            if (comment == null)
            {
                return NotFound();
            }
            return Ok(comment);
        }

        // ---------------------------------------------------------------------------

        [HttpPost]
        public IActionResult CreateComment([FromBody] CommentCreationRequest payload)
        {
            if (payload == null)
                return BadRequest(new { Message = "Payload is required." });

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            // Vérifier que l'article existe
            var article = _context.Articles.Find(payload.ArticleId);
            if (article == null)
                return NotFound(new { Message = $"Article with ID {payload.ArticleId} not found." });

            var newComment = new Comment()
            {
                ArticleId = payload.ArticleId,
                Article = article,
                Author = payload.Author ?? "Anonyme",
                Content = payload.Content ?? string.Empty,
                CreationDate = DateOnly.FromDateTime(DateTime.UtcNow)
            };

            // Ajouter le commentaire au contexte et à la collection de l'article pour cohérence en mémoire
            _context.Comments.Add(newComment);

            article.Comments ??= new List<Comment>();
            article.Comments.Add(newComment);

            _context.SaveChanges();

            var responseDto = new CommentDetailsresponse()
            {
                Id = newComment.Id,
                ArticleId = newComment.ArticleId,
                Author = newComment.Author,
                Content = newComment.Content,
                CreationDate = newComment.CreationDate.ToString(),
            };

            return CreatedAtAction(nameof(GetById), new { id = newComment.Id }, responseDto);
        }
        // ---------------------------------------------------------------------------
        [HttpDelete("{id}")]
        public IActionResult DeleteComment(int id)
        {
            var comment = _context.Comments.Find(id);
            if (comment == null)
            {
                return NotFound(new { Message = $"Comment with ID {id} not found." });
            }
            _context.Comments.Remove(comment);
            _context.SaveChanges();
            return Ok(new { Message = "Comment deleted successfully." });
        }

    }
}

