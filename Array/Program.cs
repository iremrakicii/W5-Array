class Program
{
    static void Main()
    {
        // 1 - 10 adet tam sayı verisi alacak bir dizi tanımlayınız.
        int[] sayilar = new int[10];

        // 2 - Bu dizinin elemanlarını bir for döngüsü ile doldurup, foreach döngüsü ile tekrar ekrana yazınız.
        for (int i = 0; i < 10; i++)
        {
            sayilar[i] = i;
            Console.WriteLine("Dizinin elemanları:" + sayilar[i]);
        }
        Console.WriteLine("----------------------------------");
        foreach (int i in sayilar)
        {
            Console.WriteLine("Dizinin elemanları:" + sayilar[i]);
        }

        // 3 - Bu diziye kullanıcıdan alınan yeni bir değeri ekleyiniz (11. eleman olarak)
        Array.Resize(ref sayilar, 11);
        Console.Write("Lütfen sayilar dizisinin 11.elemanı için bir değer giriniz:");
        sayilar[10] = int.Parse(Console.ReadLine());
        Console.WriteLine("Sayilar dizisinin 11.elemanı:" + sayilar[10]);

        Console.WriteLine("------------------------------------");

        //4 - Bu diziyi büyükten küçüğe ekrana yazdırınız.
        Array.Sort(sayilar);// Diziyi küçükten büyüğe sıralıyoruz
        Array.Reverse(sayilar);// Diziyi ters çevirerek büyükten küçüğe sıralıyoruz


        Console.WriteLine("Büyükten küçüğe sıralama:");
        foreach (int sayi in sayilar)
        {
            Console.WriteLine(sayi);
        }

        Console.ReadKey();

    }
}