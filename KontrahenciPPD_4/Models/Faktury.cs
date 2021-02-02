using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class FakturyIn
    {
        public string Status { get; set; }
        public float Wartosc_faktury { get; set; }
    }

    public class FakturyOut
    {
        public int IloscZaplacone { get; set; }
        public int IloscNieZaplacone { get; set; }
        public float WartoscZaplacone { get; set; }
        public float WartoscNieZaplacone { get; set; }
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