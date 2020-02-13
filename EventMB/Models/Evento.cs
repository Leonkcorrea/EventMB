using System.ComponentModel.DataAnnotations;

namespace EventMB.Models
{
    public class Evento
    {
        [Key]
        public int Id {get;set;}
         public string nome{get;set;}
        public DataType data{get;set;}
        public string local{get;set;}
        public string endereco{get;set;}
        public string classificacao{get;set;}
         public string tipo{get;set;}
          public char descricao{get;set;}

        
    }

}