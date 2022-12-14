using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace delageAPI.Models
{
    public class UsuarioModel
    {


        [Key()]
        [JsonIgnore]
        public int idUsuario { get; set; }
        [Required]
        [MaxLength(55)]
        public string nome { get; set; } = string.Empty;
        [Required]
        [MaxLength(20)]
        public string celular { get; set; } = string.Empty;
        [Required]
        [MaxLength(255)]
        public string endereco { get; set; } = string.Empty;
        [MaxLength(200)]
        [EmailAddress]
        public string email { get; set; } = string.Empty;
        [Required]
        [MaxLength(30)]
        public string loginUser { get; set; } = string.Empty;
        [Required]
        [MaxLength(20)]
        public string password { get; set; } = string.Empty;
        [JsonIgnore]
        public DateTime? dataCadastro { get; set; }

        [JsonIgnore]
        [NotMapped]
        public List<PedidoModel> Pedidos { get; set; } = new List<PedidoModel>();


       
        public bool SenhaValida(string senha)
        {
            return password == senha;
        }

    }
}
