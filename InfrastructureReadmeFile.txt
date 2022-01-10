//Bu katmanda diðer katmanlara alt yapý hizmeti sunacak olan servisleri barýndýgracagýmýz katman

//Email sms , jwt ile token haberleþme alt yapýsý, bildirim servisleri, Socket(mobil) Signalar chat ve realtime eþ zamanlý veri operasyonlarý icin kullanýlýyor cache iþlemleri icin gerekli yardýmcý uygulamamaýz icin tüm gerekli alt yapý baðlantýlarý bu katmanda yapacagýz.

//Hubs=> Socket islemlerini bu klasor altýnda yapacagýz
// Email => e posta gonderme islemlerini bu klasorde ypaacaðýz
//Notification=> Mobil uygulama icin bildirim gönderme iþlemlerini bu klasorde yapacaðýz.
//SmsOperation => sms iþlemelrini bu klasorde yapacaðýz.

//Jwt = > Client ile server arasýnda haberleþme alt ypaýsýn bu klasorde tutacaðýz. 
//Caching => Redis ile cachelenmiþ yani belirli bir süreliðine ramde tutulan bilgileri bu klasör altýndaki servisleri kullanarak geliþtirme yapacaðýz.
//Logging => Loglama iþlemleri
// Base Repository implementasyonlarý teknolojilere göre bu klasor altýnda yapýlcak.


//Bu uyguluma altýnda yukarýdak i tüm operasyonlara ait interfaceler ve bu interfacelerden implemente olan alt yapý servisleri bulunacak.

