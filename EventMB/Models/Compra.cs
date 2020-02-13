using System.ComponentModel.DataAnnotations;

namespace EventMB.Models
{
    public class Compra
    {   [Key]
        public int id_compra {get;set;}
        public int Valor {get;set;}
        public Ingresso ingressos{get;set;}
        public int qtdIngressos {get;set;}
    }

}