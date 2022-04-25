using MimeKit;
using System.ComponentModel.DataAnnotations;

namespace UsuariosAPI.Models
{
    public class Mensagem
    {
        [Required]
        public List<MailboxAddress> Destinatario { get; set; }
        public string Assunto { get; set; }
        public string Conteudo { get; set; }

        public Mensagem(IEnumerable<string> destinatario, string assunto, int id, string code)
        {
            Destinatario = new List<MailboxAddress>();
            Destinatario.AddRange(destinatario.Select(d => new MailboxAddress(d)));
            Assunto = assunto;
            Conteudo = $"http://localhost:6000/ativa?UserId={id}&CodigoDeAtivacao={code}";
        }
    }
}
