namespace HesapMakinesiOdevi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ilksayi;
            int ikincisayi;
            int sonuc;
            int fark;
            int toplam;
            int bolum;
            int carpim;

            Console.WriteLine("Hesap Makinesi Ödevi");
            Console.WriteLine("----------");
            Console.WriteLine();

            
            Console.WriteLine("İlk Sayıyı Giriniz : ");
            ilksayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci Sayıyı Giriniz : ");
            ikincisayi = Convert.ToInt32(Console.ReadLine());

            toplam = ilksayi + ikincisayi;
            fark = ilksayi - ikincisayi;
            bolum = ilksayi / ikincisayi;
            carpim = ilksayi * ikincisayi;

            Console.WriteLine();

            Console.WriteLine("Girilen 2 Sayının : ");
            Console.WriteLine("----------");
            Console.WriteLine("Toplamı : " + toplam);
            Console.WriteLine("Farkı : " + fark);
            Console.WriteLine("Bölümü : " + bolum);
            Console.WriteLine("Çarpımı : " + carpim);
            Console.WriteLine("----------");

            Console.ReadKey();
        }
    }
}
