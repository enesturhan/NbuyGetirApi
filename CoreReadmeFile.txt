
//Bu katman diğer tüm katmanları besleyen abstract sınıf base class interfaces gibi ana sablonların uygulandıgı bir katman olup tüm katmanlar bu katmandan faydalanabilir .Uygulamanın ilk geliştirmeleri bu katman üzerinden yapıp diğer katmanlara ait implementasyonları ypaıcaoxgız.
Bu katman diğer katmnlardan farklı olarak crosscuttuing katman olarak nitelendirilir. Diğer katmanlar uygulamanın belirli bir kısmına ait kendileri ile alakalı sorumlulukları(seperation of concern) yerine getirirken bu katmanda herhangi bir sorumluluk prensibi bulunmamaktadır. Sadece ilgili katmnalra ait base implementasyolnarı yer veirilir.

//Base entity ,Ientittu, Irepository, IdomainEvent, IDomainService,IEmailSender, ISmsSender , INotification, ITokenServeice gibi tüm implementasyonların basesi burada bulunacaktyrı

Note =>UI dedigimiz frontend katmanı ile baslar (html, css ,js) olup kullanıcının uygulama ile tasarımsal olarak etkilesime gectigi katmna bu katman frontend developerların katmanı bu duruma göre mobile app, web app olabilir.

UI(jquery,reactjs,angular,vue.js spa gibi uygulamalar)=>Presentation(API,WEB MVC,Desktop,(back*end katmanı) )=>Applcation (Gelen isteklerin ilgili sevislere aktarıldıgı katmna)=> infrastructure veya domain veya persistance gibi katmanlara baglar.

