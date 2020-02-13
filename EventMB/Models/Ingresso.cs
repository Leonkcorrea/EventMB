using System.ComponentModel.DataAnnotations;

namespace EventMB.Models
{
    public class Ingresso
    {
        [Key]
        public int Id_ingresso {get;set;}
        public string nome {get;set;}
        public Evento Eventos{get;set;}
    }

}