using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace delageAPI.Models
{
    public class ProdutoModel
    {
        [Key]
        [JsonIgnore]
        public int idProduto { get; set; }
        [Required]
        [StringLength(55)]
        public string nomeProduto { get; set; } = string.Empty;

        public string? caminhoImagem { get; set; } = string.Empty;

        public double preco { get; set; }
        [StringLength(140)]
        public string? observacoes { get; set; } = string.Empty;

        [ForeignKey("Restaurante")]
        public int idRestaurante { get; set; }
        [JsonIgnore]
        [NotMapped]
        public RestauranteModel? restaurante { get; set; }

    }
}
