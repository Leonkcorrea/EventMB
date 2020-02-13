using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventMB.Models
{
    public class Cliente: Pessoa
    {   [Key]
        public int id_cliente {get;set;}
        public string tipo{get;set;}
        public new Pessoa nome;
        [Key]
        public new Pessoa id_Pessoa;
        
        public new Pessoa datadenascimento;
        public new Pessoa email;
        public new Pessoa sexo;
        public new Pessoa cep;
        public new Pessoa pwd;
        public new Pessoa telefone;
    }

}