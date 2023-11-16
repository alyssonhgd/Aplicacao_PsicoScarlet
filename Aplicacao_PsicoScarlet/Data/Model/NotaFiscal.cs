using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace AplicacaoAgendamento.Shared
{
    public class NotaFiscal
    {
        public DateTime Data { get; set; }

        public string CNPJ { get; set; }

        [Key]
        public Guid NumNotaFiscal { get; set; }

        public string? DescricaoServico { get; set; }
        public Atendimento? Atendimento { get; set; }

    }
}