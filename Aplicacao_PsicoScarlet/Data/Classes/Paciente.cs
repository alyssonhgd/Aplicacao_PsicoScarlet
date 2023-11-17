using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Aplicacao_PsicoScarlet.Shared
{
    public class Paciente : IdentityUser
    {
        [Key]
        public Guid IdPaciente { get; set; }
        public int Cpf { get; set; }
        public string? Nome { get; set; }
        public DateTime? DataNascimento { get; set; }
        public int Rg { get; set; }
        public Atendimento? Atendimento;
        public Atendimento? FKAtendimentos { get; set; }
        public string? Genero { get; set; }
        public string? Telefone { get; set; }

        public int Idade { get; set; }  
        public string? LocalNascimento { get; set; }
        public string? ComposicaoFamiliar { get; set; }
        public string? EscolaDoPaciente { get; set; }
        public string? SerieEscolar { get; set; }
        public string? RendimentoEscolar { get; set; }  


        public string? NomePai { get;set; }
        public string? GrauInstrucaoPai { get; set; }
        public int IdadePai { get; set; }
        public string? EstadoCIvilPai { get; set; }
        public string? ReligiaoPai { get; set; }
        public string? NaturalidadePai { get; set; }


        public string? NomeMae { get; set; }
        public string? GrauInstrucaoMae { get; set; }   
        public int IdadeMae { get; set; }
        public string? EstadoCivilMae { get; set; } 
        public string? ReligiaoMae { get; set; }
        public string? NaturalidadeMae { get; set; }


        public string? QueixaOuMotivoConsulta { get; set; }
        public string? DesdequandoExisteProblema { get; set; }
    }






}