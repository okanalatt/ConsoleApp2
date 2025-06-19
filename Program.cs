namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. Kullanıcıdan bir sayı alın.
             * 2. Sayının çift mi tek mi olduğunu kontrol edin.
             * 3. Sonucu ekrana yazdırın.
             */
            /*
            Console.WriteLine("Bir sayi giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi % 2 == 0)
            {
                Console.WriteLine("Sayı çifttir.");
            }
            else
            {
                Console.WriteLine("Sayı tektir.");
            }
            Console.ReadLine();*/



            // Soru :Kullanıcıdan sayı ve iskonta oranını alıp sonucu veren program.
            /*Console.WriteLine("Bir sayi giriniz");
            double sayi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("İskonto oranını giriniz (örneğin %10 için 10 giriniz):");
            double iskontoOrani = Convert.ToDouble(Console.ReadLine());
            double iskontoMiktari = sayi * (iskontoOrani / 100);
            double sonuc = sayi - iskontoMiktari;
            Console.WriteLine($"İskonto miktarı: {iskontoMiktari} TL");
            Console.WriteLine($"İskontolu fiyat: {sonuc} TL");

            Console.ReadLine();*/


            // Soru: Kullanıcıdan bir sayı alıp, bu sayının faktöriyelini hesaplayan program.
            /* Console.WriteLine("Sayi giriniz:");
             int sayi = Convert.ToInt32(Console.ReadLine());
             int faktoriyel = 1;
             for (int i = 1; i <=sayi ; i++)
             {
                  faktoriyel = faktoriyel * i;
             }
             Console.WriteLine(faktoriyel);
             Console.ReadLine();
            */
            //SORU: kullanıcıdan vize ve final notunu alıp vizenin 
            //yüzde 40 i fınalın yuzde 60 ı alıp toplayan ve sonucu gosteren bır program
            Console.WriteLine("Vize notunu giriniz");
            double vize =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Final notunu gir:");
            double final = Convert.ToDouble(Console.ReadLine());
            double not = (vize * 40 / 100) + (final * 60 / 100);
            Console.WriteLine("Sonuc:{0}",not);
            Console.ReadLine();
        }
    }
}
