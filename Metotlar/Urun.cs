﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Urun
    {
        // prop tabx2
        // Property - özellik 
        public int Id { get; set; }
        public string Adi { get; set; }

        public double Fiyati { get; set;}

        public string  Aciklama { get; set;}

        public int stokAdedi { get; set; }     
    }
}
