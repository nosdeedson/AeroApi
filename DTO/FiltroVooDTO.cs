using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AeroApi.DTO
{
    public class FiltroVooDTO
    {
        public int LocalOrigemID { get; set; }

        public int LocalDestinoID { get; set; }

        public DateTime DataIda { get; set; }

        public DateTime DataVolta { get; set; }

        public int QtdPassageiroDTO { get; set; }

    }
}
