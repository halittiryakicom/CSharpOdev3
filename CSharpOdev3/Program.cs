//burada write kullanarak imlecin alt satıra geçmesine engel oluyoruz ve kullanıcının gireceği değer aynı satırda devam ediyor
Console.Write("Lütfen bir sayı giriniz: ");

//burada kullanıcıdan sayı istiyoruz ve bu sayı üzerinde mantıksal karşılaştırmalar yapacağımızdan doalyı sayısal değere çeviriyoruz.
int sayi = Convert.ToInt32(Console.ReadLine());

//burada girilen sayının 10 ile olan durumlarını kontrol ediyoruz.
if(sayi > 10)
    Console.WriteLine("Girilen sayı 10'dan büyüktür.");
else if(sayi == 10)
    Console.WriteLine("Girilen sayı 10'a eşittir.");
else
    Console.WriteLine("Girilen sayı 10'dan küçüktür.");

//burada sayının çift mi tek mi olma durumunu kontrol ediyoruz
if (sayi % 2 == 0)
    Console.WriteLine("Sayı çifttir");
else
    Console.WriteLine("Sayı Tektir.");