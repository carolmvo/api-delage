using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace delageAPI.Models
{
    public class RestauranteModel
    {
        [Key]
        public int idRestaurante { get; set; }
        
        [NotMapped]
        [JsonIgnore]
        public IFormFile? Imagem { get; set;}

        public string? caminhoImagem { get; set; } = string.Empty;

        [Required]
        [StringLength(55)]
        public string nome { get; set; } = string.Empty;

        [Required]
        [StringLength(25)]
        public string categoria { get; set; } = string.Empty;

        [Required]
        [MaxLength(255)]
        public string endereco { get; set; } = String.Empty;

        [NotMapped]
        [JsonIgnore]
        public List<ProdutoModel> Produtos { get; set; } = new List<ProdutoModel>();


        public void addProdutos(DbSet<ProdutoModel> Produtos)
        {

            var produtosList = Produtos.ToList();

            foreach (ProdutoModel produto in produtosList)
            {
                if (produto.idRestaurante == idRestaurante)
                {
                    this.Produtos.Add(produto);
                }
            }
        }
        
    }
}
