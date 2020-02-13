using System.ComponentModel.DataAnnotations;

namespace EventMB.Models
{
    public abstract class Pessoa
    {   [Key]
        public int id_Pessoa{get;set;}
        public string nome{get;set;}
        public DataType datadenascimento{get;set;}
        public EmailAddressAttribute email{get;set;}
        public bool sexo{get;set;}
        public int cep{get;set;}
        public char pwd{get;set;}
        public int telefone{get;set;}

    }

}