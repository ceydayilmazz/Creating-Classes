////1.Length
//string name = "Ceyda";
//Console.WriteLine("Length of '{0}' is {1}.", name, name.Length);
////Burada adımın kaç harf olduğunu söyledim.
////Bir string'de kaç adet harf olduğunu söylüyor.
//string name2 = "asdasdasdasdjdkfkjgjrıoewfkoewjgıwgowjkwgmlf";
//Console.WriteLine("Length of '{0}' is {1}.", name2, name2.Length);


////2.Concat
//string fname = "Ceyda ";
//string mname = "Zattirizort ";
//string lname = "Yılmaz";
//Console.WriteLine("Welcome to the page {0}!", string.Concat(string.Concat(fname, mname), lname));
////İsimleri birleştirdim. İç içe yapmamın sebebi ilk isimle orta isim beraber, yani tek isim olacaklar, sonra
////soyisimle birleştiler. Trim metoduyla boşluğu halledebiliyoruz sonra ona bak.


////3.ToUpper
////Bunu harfleri büyütmek için kullanıyoruz. yani a değil de A. 
//string str = "hAyAT Çok boKTan vE manASıZ";
//string str2 = str.ToUpper();
//Console.WriteLine(str2);


////4.ToLower
////Yukarıdakinin tam tersi. Yani harfleri küçük harfe çevirecek.
//string str = "hAyAT Çok boKTan vE manASıZ";
//string str2 = str.ToLower();
//Console.WriteLine(str2);


////5.Substring
////Kelimeyi bölüyor.
//string asd = "1234567890";
//string asd2 = asd.Substring(0, asd.Length - 4); //son 4 harften öncesini aldı.
//string asd3 = asd.Substring(3); //ilk 3 harften sonrasını aldı.
//string asd4 = asd.Substring(0, 3); //İlk harften 3. harfe kadar olanı aldı.
//string asd5 = asd.Substring(4, 3); //4. harften başladı ve 3 harfi aldı.
////yani, ilk sayı kaçta başlayacağını, ikinci sayı kaç tane alacağını belirtiyor.
//Console.WriteLine(asd2);
//Console.WriteLine(asd3);
//Console.WriteLine(asd4);
//Console.WriteLine(asd5);


////6.IndexOf
////Bir şeyi aramak için bunu kullanıyoruz. 'ctrl + f' gibi aynı.
//string[] cities = new string[] { "istanbul", "izmir", "hakkari", "yozgat", "sivas", "çanakkale" };
//Console.WriteLine("Aradığınız ili girin.");
//string srcCity = Console.ReadLine();
//srcCity.ToLower();
//int location = Array.IndexOf(cities, srcCity);
//if (location == -1)
//{
//    Console.WriteLine("Aradığınız il bulunamadı.");
//} else
//{
//    Console.WriteLine("Aradığınız il bulundu." + location);
//}


//7.LastIndexOf
//yukarıdakinin aynısı ama bunda aramaya sondan başlıyor. output olarak baştan sayıp veriyor. yani yöntem farklı
//ama sonuç aynı. örneğe gerek yok bnc <3


////8.Contains
////adı üstünde contains. o şeyi içeriyor mu? indexof'tan farkı bu direkt olup olmadığını söylüyor, o sırasını buluyor.
//Console.WriteLine("Metni giriniz.");
//string text = Console.ReadLine();
//Console.WriteLine("Aramak istediğiniz kelimeyi giriniz.");
//string search = Console.ReadLine();
//if (text.Contains(search)) 
//{
//    Console.WriteLine("Yess var");
//}
//else
//{
//    Console.WriteLine("Noo yok");
//}


////9.StartsWith
////adı üstünde belirtilen karakterlerle başlıyor mu diye bakıyoruz.
//string message = "Bu durak, hattımızın bu istikametteki son istasyonudur.";
//Console.WriteLine(message.StartsWith("B"));     //TRUE
//Console.WriteLine(message.StartsWith("b"));     //FALSE
////eğer doğruysa TRUE yazar, yanlışsa FALSE yazar. bool deniyormuş. diğer örneklerde de gördüm ama anlamamıştım.


////10.EndsWith
////adı üstünde belirtilen karakterlerle bitiyor mu diye bakıyoruz.
//string message = "Bu durak, hattımızın bu istikametteki son istasyonudur.";
//Console.WriteLine(message.EndsWith("."));          //TRUE
//Console.WriteLine(message.EndsWith("r."));          //TRUE
//Console.WriteLine(message.EndsWith("erf"));         //FALSE
////eğer doğruysa TRUE yazar, yanlışsa FALSE yazar.


////11.Replace
////değiştiriyoruz.
//string sleepy = "Of ne zaman bitecek ödev yeto";
//Console.WriteLine(sleepy);
//Console.WriteLine(sleepy.Replace("e", "ğ"));
//Console.WriteLine(sleepy.Replace(" ", "boşluk"));       //boş olan kısımlara boşluk yazdırdım.


////12.Split
////ayırıyoruz.
//string series = ("Six Feet Under,Bojack,Avatar,AOT,Rick and Morty");
//string[] serieList = series.Split(',');
//foreach (string serie in serieList)
//{
//    Console.WriteLine(serie);
//}


////13.Trim
////sadece BAŞTAKİ ve SONDAKİ boşlukları temizler, aralara dokunmaz.
//string example = "      Bugün kredi taksitlerimi ödedim             ";
//Console.WriteLine(example.Trim());

//string example2 = "BBBBBBugün kredi taksitlerimi ödedim.";
//Console.WriteLine(example2.Trim('B'));          //Burada direkt B harfini atıyor. yani ugün diye başlıyor cümle


////14.TrimStart
////Yukarıdaki trim'in sadece başını kestiği hali.
//string example = "          Nedense canım çok sıkılıyor.     m";
//Console.WriteLine(example.TrimStart());         //Baştaki boşluğu attı ama sondaki m'ye dokunmadı.
//string example2 = "###YETERRRRR";
//Console.WriteLine(example2.TrimStart('#'));


////15.TrimEnd
////start değil de end işte. açıklamaya gerek var mı yaa
//string example = "Ofiste Saddam Hüseyin konuşuluyor%%%%";
//Console.WriteLine(example.TrimEnd('%'));
//string example2 = "Ofiste Saddam Hüseyin konuşuluyormmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmfffffffff";
//Console.WriteLine(example2.TrimEnd('f','m'));


//16.Format
//değerlerin hangi formatta yazılacağını belirliyoruz. date, percent gibi alanlarda mesela. kullanımının belli 
//başlı syntaxları var. bunların ne olduğunu internetten bakar yaparım hep ezberlemeye gerek yok.



//17.Join


