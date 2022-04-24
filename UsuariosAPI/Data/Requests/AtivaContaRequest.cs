using System.ComponentModel.DataAnnotations;

namespace UsuariosAPI.Data.Requests
{
    public class AtivaContaRequest
    {
        [Required]
        public int UserId{ get; set; }
        [Required]
        public string CodigoDeAtivacao { get; set; }
    }
}
