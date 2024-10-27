# Program Açıklaması

Bu program, kullanıcıdan tam sayı verisi alarak bir dizi işlemi gerçekleştiren basit bir C# konsol uygulamasıdır. Program, dizinin elemanlarını kullanıcı girdisi ile güncelleyerek sıralama gibi işlemler yapar.

## Program Akışı

1. **Dizi Tanımlama:** 10 elemanlı bir tam sayı dizisi (`int[] sayilar`) tanımlanır.

2. **Diziyi Doldurma ve Yazdırma:**
   - Bir `for` döngüsü ile `sayilar` dizisinin elemanları 0-9 arasında otomatik olarak doldurulur.
   - `foreach` döngüsü kullanılarak dizinin mevcut elemanları ekrana yazdırılır.

3. **Kullanıcı Girdisi ile Diziye Yeni Eleman Ekleme:**
   - `Array.Resize` metodu kullanılarak dizi boyutu bir artırılır.
   - Kullanıcıdan alınan bir tam sayı değeri dizinin 11. elemanı olarak eklenir.

4. **Diziyi Büyükten Küçüğe Sıralama ve Yazdırma:**
   - `Array.Sort` metodu ile dizi önce küçükten büyüğe sıralanır.
   - `Array.Reverse` metodu ile dizi ters çevrilerek büyükten küçüğe sıralanır.
   - Son olarak sıralı dizi elemanları ekrana yazdırılır.

## Kullanılan Araç ve Teknolojiler:
Programlama Dili: C# IDE: Visual Studio
