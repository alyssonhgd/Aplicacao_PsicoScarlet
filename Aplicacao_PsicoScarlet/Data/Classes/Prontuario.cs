using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Aplicacao_PsicoScarlet.Shared
{
    public class Prontuario
    {
        [Key]
        public Guid IdProntuario { get; set; } 
        public int DescricaoProntuario { get; set; }
        public Paciente? Paciente { get; set; }
    }

}