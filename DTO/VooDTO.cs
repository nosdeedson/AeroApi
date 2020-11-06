using System;
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

        public string Classe { get; set; }


        public int qtdPassageiro { get; set; }
    }
}
