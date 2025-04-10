
using İnsanlar;

İnsan insan;

Console.Write("Cinsiyet giriniz (E/K): ");
string cinsiyet = Console.ReadLine();
if (cinsiyet == "E")
{
    insan = new Erkek();
}
else if (cinsiyet == "K")
{
    insan = new Kadın();
}
else
{
    Console.WriteLine("Geçersiz cinsiyet.");
    return;
}
Console.Write("Adınız .... ");
insan.AD = Console.ReadLine();
Console.Write("Soyadınız .... ");
insan.SOYAD = Console.ReadLine();
Console.Write("Yaşınızı Giriniz .... ");
insan.YAS = Convert.ToInt16(Console.ReadLine());
if (insan is Erkek erkek)
{
    Console.Write("Askerlik Durumu nedir ... ");
    erkek.ASKERLİKDURUMU = Console.ReadLine();
    Console.WriteLine(insan.AD);
    Console.WriteLine(insan.SOYAD);
    Console.WriteLine(insan.CİNSİYET);
    Console.WriteLine(insan.YAS.ToString());
    Console.WriteLine(erkek.ASKERLİKDURUMU);
}
else if (insan is Kadın kadın)
{
    Console.Write("Favori Makyajınızı Giriniz ... ");
    kadın.MAKYAJ = Console.ReadLine();
    Console.Write("Sac renginizi giriniz ... ");
    kadın.SACRENGi = Console.ReadLine();
    Console.WriteLine(insan.AD);
    Console.WriteLine(insan.SOYAD);
    Console.WriteLine(insan.CİNSİYET);
    Console.WriteLine(insan.YAS.ToString());
    Console.WriteLine(kadın.MAKYAJ);
    Console.WriteLine(kadın.SACRENGi);
}
else
{
    Console.WriteLine("Lütfen doğru harf giriniz ...");
}

    Console.ReadKey();
