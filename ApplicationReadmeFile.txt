
//Bu katman controllerden gelen i� isteklerinini kordinasyonun y�netimini yapan katman olup, bu katmandaki application servisler ile uygulaman�n di�er katmanlardaki serviseler bu katman�n icinde olup birbileri haberle�ir. Yani bu katman�n g�revi gelen i� isteklerinin use-case kullan�m duurmlar�n� g�re arka planda ne t�r i�lemlerinin �a��r�laca�g�n� koordine etmektir.

//GetCampaignProducts => Arka plandaki t�m kampanyal� �r�nleri d�zg�n bir logicte listelenmesi icin gereken t�m servislerin cag�r�lmas�n� bu katman sa�layacak.

//	Son 10 siparisimi getir. GetTop10LatestOrderRequest. => Dto yani data transfer objesi d�nd�recek .

//{"name":"siparis ad�" , "date":"siparis tarihi",} gibi olabilir.

//Bu katmanda gelen i� istegine g�re verinin yani input modelin dogru formatta olup olmad�g�n� validasyonu, dogru formatta ise yapl�lacak islemlerin cag�r�lmas� ilgili servis cagr�lar� bu operasyonlar sonras� yap�lakca islemler mail at sms at bildirim g�nder vs gibi operasyonlar�n y�netimi sa�lanacakt�r.

//Services => Gelen i� isteklerini requestleri yaklan ve i�leyen servislerimiz
Dto  => Front end tarf�ndan gelen modeller veya frontend projesine g�nderitigimiz modeller
Commands=> Uygulama icerisinde gelen i� isteklerini temsil eden komut s�n�flar� 
Queries = > Uygulama icerisindeki nesneleri frontend taraf�ndan g�ndermekten sorumlu istek s�n�flar� (GetRequest)
Exceptions = > Uygulamam�n di�er katmanlara eri�meden �nceki hata durum y�netimleri icin bu klasordeki s�n�flar� kullan�cag�z.UserNotallow, OrderRejected gibi s�n�flar olusturacag�z.
//Bu katman kontoller icerisine yaz�lan kodlar� temsil eden katman�m�zd�r.

Not: Bu katman� kullan�lmas�ndaki en b�y�k sebep uygulaman�n teknolojisini yani api teknolojisinin de�i�mesi durumunda yeni gelen teknolojinin aktar�lmas�n�n daha kolay olmas� Yani api taraf�nda yeni bir teknoloji degisiminde yeni migrayion ile ge�i� saglayacag�z.