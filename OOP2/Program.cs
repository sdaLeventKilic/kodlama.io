using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.ID = 1;
            musteri1.MusteriNo = "42342342";
            musteri1.Adi = "Levent";
            musteri1.Soyadi = "kilic";
            musteri1.TCno = "14234324234";
            

           TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.ID = 2;
            musteri2.MusteriNo = "989234234";
            musteri2.SirketAdi = "Kodlama Corp";
            musteri2.VergiNo = "345345345";




        }
    }
}
