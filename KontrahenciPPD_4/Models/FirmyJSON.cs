﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class FirmyJSON
    {
        public int ID { get; set; }
        public string Nazwa { get; set; }
        public string Adres { get; set; }
        public string NIP { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
    }
}