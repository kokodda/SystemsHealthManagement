﻿using System;
using Integra.Dominio;

namespace Integra.Web.Models
{
    public class AdicionarServicoContratoViewModel
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public string Observacoes { get; set; }
        public DateTime DataContratacao { get; set; }
    }
}