using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace AplicacaoAgendamento.Shared
{
    public class Paciente : IdentityUser
    {
        [Key]
        public Guid IdPaciente { get; set; }
        public int Cpf { get; set; }
        [DisplayName("Nome Completo")]
        [Required(ErrorMessage = "É necessario colocar a Nome do paciente")]
        public int Nome { get; set; }

        [DisplayName("Data de Nascimento")]
        [Required(ErrorMessage = "É necessario colocar a data de Nascimento")]
        public int DataNascimento { get; set; }

        [DisplayName("Peso")]
        public int Peso { get; set; }

        [DisplayName("Altura")]
        public int Altura { get; set; }
        
        public int Rg { get; set; }
        public Atendimento? Atendimento;
        public Atendimento? FKAtendimentos { get; set; }

        [DisplayName("Genero")]
        [Required(ErrorMessage = "É necessario colocar o genero do paciente")]
        public string? Genero { get; set; }

        [Required]
        [RegularExpression(@"^[0][1-9]([.][0-9][0-9]){4}", ErrorMessage = "Incorreto Numero telefone!")]
        public string? Telefone { get; set; }
    }
}