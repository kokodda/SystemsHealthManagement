﻿using System.Collections.Generic;

namespace Integra.Web.Models
{
    public class PreviaFaturamentoViewModel
    {
        public List<ClinicaViewModel> Clinicas { get; set; }
        public dynamic Meses { get; set; }
        public List<int> Anos { get; set; }
    }
}