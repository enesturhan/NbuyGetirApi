
//Bu katman di�er t�m katmanlar� besleyen abstract s�n�f base class interfaces gibi ana sablonlar�n uyguland�g� bir katman olup t�m katmanlar bu katmandan faydalanabilir .Uygulaman�n ilk geli�tirmeleri bu katman �zerinden yap�p di�er katmanlara ait implementasyonlar� ypa�caoxg�z.
Bu katman di�er katmnlardan farkl� olarak crosscuttuing katman olarak nitelendirilir. Di�er katmanlar uygulaman�n belirli bir k�sm�na ait kendileri ile alakal� sorumluluklar�(seperation of concern) yerine getirirken bu katmanda herhangi bir sorumluluk prensibi bulunmamaktad�r. Sadece ilgili katmnalra ait base implementasyolnar� yer veirilir.

//Base entity ,Ientittu, Irepository, IdomainEvent, IDomainService,IEmailSender, ISmsSender , INotification, ITokenServeice gibi t�m implementasyonlar�n basesi burada bulunacaktyr�

Note =>UI dedigimiz frontend katman� ile baslar (html, css ,js) olup kullan�c�n�n uygulama ile tasar�msal olarak etkilesime gectigi katmna bu katman frontend developerlar�n katman� bu duruma g�re mobile app, web app olabilir.

UI(jquery,reactjs,angular,vue.js spa gibi uygulamalar)=>Presentation(API,WEB MVC,Desktop,(back*end katman�) )=>Applcation (Gelen isteklerin ilgili sevislere aktar�ld�g� katmna)=> infrastructure veya domain veya persistance gibi katmanlara baglar.

