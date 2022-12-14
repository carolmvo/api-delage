using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ifoodAPI.Models
{
    public class PedidoModel
    {
        [Key()]
        public int IdPedido { get; set; }

        [ForeignKey("Produto")]
        public int IdProduto { get; set; }
        [JsonIgnore]
        [NotMapped]
        public ProdutoModel? Produto { get; set; }

        [ForeignKey("Usuario")]
        public int IdUsuario { get; set; }
        [JsonIgnore]
        [NotMapped]
        public UsuarioModel? Usuario { get; set; }

        [ForeignKey("Restaurante")]
        public int IdRestaurante { get; set; }
        [JsonIgnore]
        [NotMapped]
        public RestauranteModel? Restaurante { get; set; }

        [JsonIgnore]
        public DateTime? DataPedido { get; set; }
        [StringLength(10)]
        public string? Referencia { get; set; }
            

    }
}
