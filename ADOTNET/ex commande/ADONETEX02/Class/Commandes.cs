using System;
using System.Collections.Generic;
using System.Text;

namespace ADONETEX02.Class
{
    internal class Commandes
    {
        public int Id {  get; set; }
        public int ClientId { get; set; }
        public string Date { get; set; }
        public double Total { get; set; }

        public Commandes() { }
        public Commandes(int clientId, string date, double total)
        {
            ClientId = clientId;
            Date = date;
            Total = total;
        }
        //format date sql : 2018-09-24 

        public Commandes (int id, int clientId, string date, double total) : this(clientId, date, total)
        {
            Id = id;
        }
        public override string ToString()
        {
            return $@"numero commande: {Id}|| id client {ClientId} || date: {Date}, || Total de la commande : {Total} ";
        }

    }
}
