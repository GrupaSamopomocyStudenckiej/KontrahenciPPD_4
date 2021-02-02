using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class FakturyIn
    {
        public string Status { get; set; }
        public float Wartosc_faktury { get; set; }
    }

    public class FakturyOut
    {
        [JsonProperty("IloscZaplacone")]
        public int IloscZaplacone { get; set; }
        [JsonProperty("IloscNieZaplacone")]
        public int IloscNieZaplacone { get; set; }
        [JsonProperty("WartoscZaplacone")]
        public float WartoscZaplacone { get; set; }
        [JsonProperty("WartoscNieZaplacone")]
        public float WartoscNieZaplacone { get; set; }
        [JsonProperty("SaldoOstateczne")]
        public string SaldoOstateczne { get; set; }

        public FakturyOut(int iz, int inz, float wz, float wnz, string so)
        {
            IloscZaplacone = iz;
            IloscNieZaplacone = inz;
            WartoscZaplacone = wz;
            WartoscNieZaplacone = wnz;
            SaldoOstateczne = so;
        }
    }
}