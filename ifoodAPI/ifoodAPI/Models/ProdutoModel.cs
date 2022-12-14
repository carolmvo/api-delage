using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ifoodAPI.Models
{
    public class ProdutoModel
    {
        [Key]
        [JsonIgnore]
        public int IdProduto { get; set; }
        [Required]
        [StringLength(55)]
        public string NomeProduto { get; set; } = string.Empty;

        public string? CaminhoImagem { get; set; } = string.Empty;

        public double Preco { get; set; }
        [StringLength(140)]
        public string? Observacoes { get; set; } = string.Empty;

        [ForeignKey("Restaurante")]
        public int IdRestaurante { get; set; }
        [JsonIgnore]
        [NotMapped]
        public RestauranteModel? Restaurante { get; set; }

    }
}
