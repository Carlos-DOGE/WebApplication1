using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Display(Name = "Codigo")]
        [Column("Id")]
        
        public int id { get; set; }
        [Display(Name = "CodigoProduto")]
        [Column("CodigoProduto")]
        public int ProductCode { get; set; }
        
        [Display(Name = "Contexto")]
        [Column("Contexto")]
        public string? Context { get; set; }
        
        [Display(Name = "UnidadeDePreco")]
        [Column("UnidadeDePreco")]
        public decimal UnitPrice { get; set; }
        
        [Display(Name = "listaDePreco")]
        [Column("listaDePreco")]
        public string? PriceList { get; set; }
    }
}
