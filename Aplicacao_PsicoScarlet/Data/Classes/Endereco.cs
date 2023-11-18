using System.ComponentModel.DataAnnotations;

namespace Aplicacao_PsicoScarlet.Data.Classes
{
    public class Endereco
    {
        [Key]
        [Required]
        public Guid IdEndereco { get; set; }
        public string Rua { get; set; } = string.Empty;
        public string Cidade { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;  
        public string? CEP { get; set; }
        public string?  numero { get; set; }



    }
}
