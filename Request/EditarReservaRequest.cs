﻿using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AeroApi.Request
{
    public class EditarReservaRequest
    {

        public String Documento { get; set; }

        public int Poltrona { get; set; }


    }
}
