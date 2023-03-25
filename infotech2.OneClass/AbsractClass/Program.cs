// See https://aka.ms/new-console-template for more information
using AbsractClass;

masa mmasa=new masa();// nesne tanımlandı
// Kullanıcıdan masa renginin değerini istiyoruz.
Console.WriteLine("Masanın rengini giriniz : ");
// Console ekranından her gelen değer string tipinde olduğu
// için ve karşılayan değişken tipimiz string olduğu için
// convert (değiştirme) işlemini kullanmıyoruz.
mmasa.renk = Console.ReadLine();
Console.WriteLine("Masanın malzemesini giriniz : ");
mmasa.malzeme = Console.ReadLine();
// önümüzdeki siyah ekranın daha önce yazılı olan metinlerini
// ekrandan kaldırır yada temizler.
Console.Clear();
// masa nesnesinden özellik yaz metodunu program cs te
//çalıştıracağız.

koltuk kkoltuk= new koltuk(); // nesne tanımlandı
// Kullanıcıdan masa renginin değerini istiyoruz.
Console.WriteLine("Koltuğun rengini giriniz : ");
// Console ekranından her gelen değer string tipinde olduğu
// için ve karşılayan değişken tipimiz string olduğu için
// convert (değiştirme) işlemini kullanmıyoruz.
kkoltuk.renk = Console.ReadLine();
Console.WriteLine("Koltuğun kumaş malzemesini giriniz : ");
kkoltuk.kumas = Console.ReadLine();
mmasa.ozellikYaz();
kkoltuk.ozellikYaz();