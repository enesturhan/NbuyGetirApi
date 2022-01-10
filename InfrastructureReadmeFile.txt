//Bu katmanda di�er katmanlara alt yap� hizmeti sunacak olan servisleri bar�nd�gracag�m�z katman

//Email sms , jwt ile token haberle�me alt yap�s�, bildirim servisleri, Socket(mobil) Signalar chat ve realtime e� zamanl� veri operasyonlar� icin kullan�l�yor cache i�lemleri icin gerekli yard�mc� uygulamama�z icin t�m gerekli alt yap� ba�lant�lar� bu katmanda yapacag�z.

//Hubs=> Socket islemlerini bu klasor alt�nda yapacag�z
// Email => e posta gonderme islemlerini bu klasorde ypaaca��z
//Notification=> Mobil uygulama icin bildirim g�nderme i�lemlerini bu klasorde yapaca��z.
//SmsOperation => sms i�lemelrini bu klasorde yapaca��z.

//Jwt = > Client ile server aras�nda haberle�me alt ypa�s�n bu klasorde tutaca��z. 
//Caching => Redis ile cachelenmi� yani belirli bir s�reli�ine ramde tutulan bilgileri bu klas�r alt�ndaki servisleri kullanarak geli�tirme yapaca��z.
//Logging => Loglama i�lemleri
// Base Repository implementasyonlar� teknolojilere g�re bu klasor alt�nda yap�lcak.


//Bu uyguluma alt�nda yukar�dak i t�m operasyonlara ait interfaceler ve bu interfacelerden implemente olan alt yap� servisleri bulunacak.

