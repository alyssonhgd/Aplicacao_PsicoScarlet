using Aplicacao_PsicoScarlet.Shared;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Aplicacao_PsicoScarlet.Data.Models
{
    public class ModelPaciente
    {
        [Key]
        public Guid IdPaciente { get; set; }
        public string? RG {  get; set; } = null;
        public string? Cpf { get; set; } = string.Empty;



        [DisplayName("Nome Completo")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "É necessario colocar a Nome do paciente")]
        public string Nome { get; set; }

        [DisplayName("Data de Nascimento")]
        [Required(ErrorMessage = "É necessario colocar a data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [DisplayName("Peso")]
        public string? Peso { get; set; }

        [DisplayName("Altura")]
        public string? Altura { get; set; }


        [DisplayName("Genero")]
        [Required(ErrorMessage = "É necessario colocar o gênero do paciente")]
        public string Genero { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "É necessario colocar o telefone do paciente")]
        [RegularExpression(@"^([+]?\d{1,2}[-\s]?|)\d{3}[-\s]?\d{3}[-\s]?\d{4}$", ErrorMessage = "Numero telefone Inválido!")]
        public string TelefonePai { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "É necessario colocar o telefone do paciente")]
        [RegularExpression(@"^([+]?\d{1,2}[-\s]?|)\d{3}[-\s]?\d{3}[-\s]?\d{4}$", ErrorMessage = "Numero telefone Inválido!")]
        public string TelefoneMae { get; set; }

        [DisplayName("Email")]
        [RegularExpression(@"^((?!\.)[\w-_.]*[^.])(@\w+)(\.\w+(\.\w+)?[^.\W])$", ErrorMessage = "Email Inválido!")]
        public string Email { get; set; }


        public string? Idade { get; set; }
        public string? LocalNascimento { get; set; }
        public string? ComposicaoFamiliar { get; set; }
        public string? EscolaDoPaciente { get; set; }
        public string? SerieEscolar { get; set; }
        public string? RendimentoEscolar { get; set; }


        public string? NomePai { get; set; }
        public string? GrauInstrucaoPai { get; set; }
        public string? IdadePai { get; set; }
        public string? EstadoCIvilPai { get; set; }
        public string? ReligiaoPai { get; set; }
        public string? NaturalidadePai { get; set; }
        public string? ProfissaoPai { get; set; }


        public string? NomeMae { get; set; }
        public string? GrauInstrucaoMae { get; set; }
        public string? IdadeMae { get; set; }
        public string? EstadoCivilMae { get; set; }
        public string? ReligiaoMae { get; set; }
        public string? NaturalidadeMae { get; set; }
        public string? ProfissaoMae { get; set; }


        public string? QueixaAnterior { get; set; } 
        public string? QuantoTempoQueixas { get; set; }
    }
}
