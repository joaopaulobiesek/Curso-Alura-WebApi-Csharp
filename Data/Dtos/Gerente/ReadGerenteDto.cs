using FilmeAPI.Models;

namespace FilmeAPI.Data.Dtos
{
    public class ReadGerenteDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public object Cinemas { get; set; }
    }
}
