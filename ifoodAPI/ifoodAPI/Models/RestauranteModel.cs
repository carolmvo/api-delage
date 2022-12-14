using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ifoodAPI.Models
{
    public class RestauranteModel
    {
        [Key]
        public int IdRestaurante { get; set; }
        
        [NotMapped]
        [JsonIgnore]
        public IFormFile? Imagem { get; set;}

        public string? CaminhoImagem { get; set; } = string.Empty;

        [Required]
        [StringLength(55)]
        public string Nome { get; set; } = string.Empty;

        [Required]
        [StringLength(25)]
        public string Categoria { get; set; } = string.Empty;

        [Required]
        [MaxLength(255)]
        public string Endereco { get; set; } = String.Empty;

        [NotMapped]
        [JsonIgnore]
        public List<ProdutoModel> Produtos { get; set; } = new List<ProdutoModel>();


        public void addProdutos(DbSet<ProdutoModel> Produtos)
        {

            var produtosList = Produtos.ToList();

            foreach (ProdutoModel produto in produtosList)
            {
                if (produto.IdRestaurante == IdRestaurante)
                {
                    this.Produtos.Add(produto);
                }
            }
        }
        
    }
}
