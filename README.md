# Otel Otomasyonu

Selman KAYA 192523208

Yöneticinin kullanıcı adı ve parola girerek sisteme giriş yaptığı, şifresini ve parolasını güncelleyebildiği, otele müşteri kaydı oluşturup otelden çıkış yapan müşterilerin ödemesi gereken tutarın hesaplandığı, odaların boş mu dolumu olduğunun kontrollerinin yapılabildiği ve yeni müşteri geldiğinde yeşil renkli olan boş odaların kırmızı renge döndüğü, müşterilerin şikayetlerini veya taleplerini oluşturabildiği, yöneticinin ise müşterilerden gelen geri bildirimleri görebildiği, alınan ürünlerin ve ödenen faturaların kaydının tutulduğu daha sonra gelir gider sayfasından personel maaşları dahil tüm masrafların ve gelirlerin hesaplanıp kar zarar durumunun gösterildiği, yöneticinin giriş yaptıktan sonra isterse radyo dinleyip gazete okuyabileceği şekilde dizayn edilmiş bir otomasyondur.


Uygulama Dili - C#

Veri Tabanı Dili - MSSQL

Yönetici kullanıcı adı ve şifresini girerek giriş yapablir ayrıca her odada bulunan bilgisayarlar aracılığıyla her müşterinin uşaşabileceği bir sayfadır. Bu sayfada müşteriler geri bildirimlerini ad-soyadlarını girerek kaydedebilir.

![Giriş Ekranı](https://user-images.githubusercontent.com/106451074/170855236-94cb3135-b8a7-449f-8dd7-62b119986d24.PNG)

Anasayfadır, yönetici tercihine göre istediği sayfaya giriş yaparak istediği bilgiyi kontrol edebilir. Ayrıca isteğe göre radyo dinleyip gazete okuyabilir.

![Anasayfa](https://user-images.githubusercontent.com/106451074/170855247-05204d4e-c8da-42b3-9c21-168c36164b3d.PNG)

Yönetici odaların dolumu boşmu olduğunu kontrol edebilir boş olan odalar yeşil renkli görünürken dolu olan odalar kırmızı renkli görünmektedir.

![Odalar](https://user-images.githubusercontent.com/106451074/170855250-c14c87bb-9fe7-4c08-86d0-b08c9a39bd24.PNG)

Müşterilerin bilgilerinin girilerek oda kaydı yapıldığı sayfadır. giriş, çıkış tarihlerine göre ve kaldığı odaya göre ücret belirlenir. 100'den 108'e kadar olan odaların günlüğü 100 TL, 200'den 208'e kadar olan odaların günlüğü 200 TL ve 300'den 308'e kadar olan odaların günlüğü 300 TL dir. Radio Buttonlar aracılığıyla ücretler hesaplanır.

![Müsteri Ekleme](https://user-images.githubusercontent.com/106451074/170855251-487542e6-5bc4-4844-a0a6-d49540546fe1.PNG)

Müşterilerin bilgilerinin gösterildiği sayfadır arama butonuyla müşteri kaydı bulunabilir ve bilgiler istenirse güncellenebilir veya silinebilir. Ayrıca bu sayfada müşterilerin otele giriş-çıkış tarihleri ve ne kadar ücret ödedikleride görülmektedir.

![Müşteriler](https://user-images.githubusercontent.com/106451074/170855252-e59cdf27-9aaa-418b-96e7-694f1b975ba4.PNG)

Yöneticinin kullanıcı adı ve şifresini güncelleyebildiği sayfadır.

![Şifre Güncelleme](https://user-images.githubusercontent.com/106451074/170855258-93ef3ac7-ae92-4eb0-b2ea-75e32d9e1ba9.PNG)

Bu sayfada personel sayısına göre peronele ödenen toplam maaşlar hesaplanabilir. Otele giren müşterilerden elde edilen gelirler kasadaki toplam tutar olarak gösterilir. Otele giren malzeme giderleri, ödenen fatura giderleri ve personellerin maaş giderleri elde edilen gelirden çıkarılarak sonuç kısmında kar-zarar durumu görünür.

![Gelir Giderler](https://user-images.githubusercontent.com/106451074/170855264-38102e64-4e43-443d-a168-5fde43ded0a9.PNG)

Alınan malzemelerin ve ödenen faturaların tutarlarının kaydedildiği sayfadır. Bir önceki sayfada gösterilen giderler bu sayfadaki kayıtlardan oluşur. 

![Stoklar ve Faturalar](https://user-images.githubusercontent.com/106451074/170855265-efe2c702-2092-4056-816f-385250320de3.PNG)

Bu sayfada müşterilerden gelen geribildirimler gösterilmektedir.

![Müşteri Mesajları](https://user-images.githubusercontent.com/106451074/170855268-0fa240a1-f352-4b29-89f5-9e02e69617cb.PNG)

Yönetici isterse radyo açıp dinleyebilir.

![Radyo Dinle](https://user-images.githubusercontent.com/106451074/170855269-93726e00-c2a1-42f2-991a-c1edca2e2c89.PNG)
