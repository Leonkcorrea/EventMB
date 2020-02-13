using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventMB.Models
{
    public class PromoEvent: Pessoa
    {   [Key]
        public int id_PromoEvent {get;set;}
        public string nomeFantasia{get;set;}
        public int inscricaoMuni{get;set;}
        public int agencia{get;set;}
        public int conta{get;set;}
        public int cnpj{get;set;}
        public string razaoSocial{get;set;}
        public new Pessoa nome;
        [ForeignKey("id_Pessoa")]
        public new Pessoa id_Pessoa;
        
        public new Pessoa datadenascimento;
        public new Pessoa email;
        public new Pessoa sexo;
        public new Pessoa cep;
        public new Pessoa pwd;
        public new Pessoa telefone;
        
    }

}