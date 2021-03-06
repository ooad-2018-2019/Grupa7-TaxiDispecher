﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaxiDispecer.Models
{
    public class Vozac : Osoba
    {
        [ScaffoldColumn(false)]
        public String BrojTransakcijskogRacuna { get; set; }

        [StringLength(10)]
        public String BrojUgovora { get; set;  }

        public String BrojLicence { get; set; }

    }
}
