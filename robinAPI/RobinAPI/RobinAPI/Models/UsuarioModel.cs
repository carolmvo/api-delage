using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace robinAPI.Models
{
    public class UsuarioModel
    {


        [Key()]
        [JsonIgnore]
        public int IdUsuario { get; set; }
        [Required]
        [MaxLength(55)]
        public string Nome { get; set; } = string.Empty;
        [Required]
        [MaxLength(20)]
        public string Celular { get; set; } = string.Empty;
        [Required]
        [MaxLength(255)]
        public string Endereco { get; set; } = string.Empty;
        [MaxLength(200)]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        [MaxLength(30)]
        public string LoginUser { get; set; } = string.Empty;
        [Required]
        [MaxLength(20)]
        public string Password { get; set; } = string.Empty;
        [JsonIgnore]
        public DateTime? DataCadastro { get; set; }

        [JsonIgnore]
        [NotMapped]
        public List<PedidoModel> Pedidos { get; set; } = new List<PedidoModel>();


       
        public bool SenhaValida(string senha)
        {
            return Password == senha;
        }

    }
}
