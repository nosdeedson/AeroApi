﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AeroApi.DTO
{
    public class VooDTO
    { //LocalOrigem/LocalDestino/DataIda/DataVolta/Classe/qtdPassageiro

        public int LocalOrigemID { get; set; }

        public int LocalDestinoID { get; set; }

        public DateTime DataIda { get; set; }

        public DateTime DataVolta { get; set; }

        public int QtdPassageiroDTO { get; set; }

        public int NumeroParadas { get; set; }

        public TimeSpan TempoVolta { get; set; }

        public TimeSpan TempoIda { get; set; }

        public double Preco { get; set; }

    }
}
