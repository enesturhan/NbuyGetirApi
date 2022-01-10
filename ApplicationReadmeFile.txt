
//Bu katman controllerden gelen iþ isteklerinini kordinasyonun yönetimini yapan katman olup, bu katmandaki application servisler ile uygulamanýn diðer katmanlardaki serviseler bu katmanýn icinde olup birbileri haberleþir. Yani bu katmanýn görevi gelen iþ isteklerinin use-case kullaným duurmlarýný göre arka planda ne tür iþlemlerinin çaðýrýlacaýgýný koordine etmektir.

//GetCampaignProducts => Arka plandaki tüm kampanyalý ürünleri düzgün bir logicte listelenmesi icin gereken tüm servislerin cagýrýlmasýný bu katman saðlayacak.

//	Son 10 siparisimi getir. GetTop10LatestOrderRequest. => Dto yani data transfer objesi döndürecek .

//{"name":"siparis adý" , "date":"siparis tarihi",} gibi olabilir.

//Bu katmanda gelen iþ istegine göre verinin yani input modelin dogru formatta olup olmadýgýný validasyonu, dogru formatta ise yaplýlacak islemlerin cagýrýlmasý ilgili servis cagrýlarý bu operasyonlar sonrasý yapýlakca islemler mail at sms at bildirim gönder vs gibi operasyonlarýn yönetimi saðlanacaktýr.

//Services => Gelen iþ isteklerini requestleri yaklan ve iþleyen servislerimiz
Dto  => Front end tarfýndan gelen modeller veya frontend projesine gönderitigimiz modeller
Commands=> Uygulama icerisinde gelen iþ isteklerini temsil eden komut sýnýflarý 
Queries = > Uygulama icerisindeki nesneleri frontend tarafýndan göndermekten sorumlu istek sýnýflarý (GetRequest)
Exceptions = > Uygulamamýn diðer katmanlara eriþmeden önceki hata durum yönetimleri icin bu klasordeki sýnýflarý kullanýcagýz.UserNotallow, OrderRejected gibi sýnýflar olusturacagýz.
//Bu katman kontoller icerisine yazýlan kodlarý temsil eden katmanýmýzdýr.

Not: Bu katmaný kullanýlmasýndaki en büyük sebep uygulamanýn teknolojisini yani api teknolojisinin deðiþmesi durumunda yeni gelen teknolojinin aktarýlmasýnýn daha kolay olmasý Yani api tarafýnda yeni bir teknoloji degisiminde yeni migrayion ile geçiþ saglayacagýz.