﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AeroApi.Model
{
    public class Voo
    {
        public int Id { get; set; }

        public DateTime DataIda { get; set; }

        public DateTime DataVolta { get; set; }

        public int LocalOrigemId { get; set; }

        public Local LocalOrigem { get; set; }

        public int LocalDestinoId { get; set; }

        public Local LocalDestino { get; set; }

        public int NumeroParadas { get; set; }

        public TimeSpan TempoIda { get; set; }

        public TimeSpan TempoVolta { get; set; }

        public Double Preco { get; set; }

        public int QtdPassageiros { get; set; }

       
    }
}
