# Katmanli-mimari-ve-MVC-ile-E-Ticaret-Sitesi

# Projenin Açıklaması
Yaptığım projede hepsiburada, trendyol ve gittigidiyor gibi siteleri örnek olarak yaptığım ve katmanlı mimari MVC kullarak ortaya çıkardığım bir E-Ticaret sitesidir.
Proje de E-Ticaret sitesinin anasayfası aşağıdaki gibidir. Sitenin anasayfasında slider olup aşağı kısımda ise sol tarafta kategoriler mevcuttur. Kategorilerin hemen sağında ise yine sitede bulunan ürünler mevcuttur. Detaylar aşağıdaki gibi resimlerle desteklenmiştir.
![1](https://user-images.githubusercontent.com/79757076/129763711-279b8847-132b-4a2b-9ede-911551d1a385.png)
![2](https://user-images.githubusercontent.com/79757076/129764663-ca842fe4-1745-447c-b137-3f3407c56293.png)
![3](https://user-images.githubusercontent.com/79757076/129764714-eddb8cb0-6b2c-49f2-aa98-fc0252b9d4d5.png)
Ek olarak her ürünün bulunduğu karta Detaylar ve sepete ekle seçeneklerini koydum.
![4](https://user-images.githubusercontent.com/79757076/129765098-e8772931-110b-4efd-b98e-8f424146d3e5.png)
Ürünler kısmına gittiğimde ise yine sabit bir şekilde kategoriler kısmı duruyor ve ürünler hakkında bilgi edinebiliyoruz.
![5](https://user-images.githubusercontent.com/79757076/129765201-c9ebea04-c348-4242-b1b5-ba014f919a63.png)
Herhangi bir ürünü seçtiğimizde ise detay, fiyat bilgisi ve sepete ekle seçenekleri vardır.
![6](https://user-images.githubusercontent.com/79757076/129765410-3b3810c6-8f3e-4982-b9ec-82e82cf35a29.png)
Aynı zamanda her bir ürünün hangi kategoriye girdiğini URL kısmında bilgi olarak gösterdim.
![7](https://user-images.githubusercontent.com/79757076/129765538-db7637ce-e63e-4c26-b206-a2a1d9b5f827.png)
![8](https://user-images.githubusercontent.com/79757076/129765638-75763620-c544-4928-9e4f-0a5815fcc085.png)
Yeni bir ürün ekleme ve oluşturma sayfaları;
![9](https://user-images.githubusercontent.com/79757076/129765723-9c35c6ce-7da8-4e38-93a7-50468142cf21.png)
Aynı zamanda sitede var olan ürünleri Id, Resim, Ürün Adı ve fiyat bilgisi şeklinde listeleyen bir admin tarafında ürünler sayfası ekledim. Buralar da bir ürüne ait silme veya düzenleme işlemleri de yapabiliyoruz.
![10](https://user-images.githubusercontent.com/79757076/129765896-0be1a124-3587-4d36-9406-508180158066.png)
Ürün düzenleme sayfasına geldiğimizde görüldüğü üzere ürüne ait tüm bilgileri düzenleyebiliyoruzç
![11](https://user-images.githubusercontent.com/79757076/129766164-2b2bb839-ec6b-4b49-8fc3-1eccc50ca54c.png)
Admin tarafında yine kategorileri düzenleme ve silme seçenekleri mevcut;
![12](https://user-images.githubusercontent.com/79757076/129766244-e93c28dc-5c88-43dd-b3eb-6f4eaa8ee959.png)
Var olan kategoriyi düzenleyebiliyoruz. Aynı zamanda seçilen kategoriye ait ürünler listelenir.
![13](https://user-images.githubusercontent.com/79757076/129766477-647a4140-79d9-4ab8-8a22-61e16d49ceb6.png)
Yeni ürün ekleme veya düzenleme seçeneklerinde verilen alanların zorunlu olduğunu ve bazı aralıklar arasında bilgi girilmesi gerektiği şeklinde uyarılar oluşturdum.![14](https://user-images.githubusercontent.com/79757076/129766717-db039053-c52a-42a6-b165-05dda0ebdc56.png)
![15](https://user-images.githubusercontent.com/79757076/129766722-21e429c0-d3e3-4877-ac90-cd802322ca64.png)
Yeni kullanıcı kaydı oluşturma sırasında aşağıdaki bilgilerin girilmesini zorunlu tuttum ve tekrar şifre girildiğinde kontrol sağlayarak şifreler arası uyuşmamazlığı ortadan kaldırdım.
![16](https://user-images.githubusercontent.com/79757076/129767047-7e20d487-57de-469c-ae43-e590403f8cf5.png)
![17](https://user-images.githubusercontent.com/79757076/129767067-6ed35db7-347a-4dbc-b056-74236e49386a.png)
Yeni kullanıcı kaydı direkt olarak veritabanına düşüyor.
![18](https://user-images.githubusercontent.com/79757076/129767173-cc5cd644-1bff-4b1a-9074-005387eaca40.png)
Ve kayıt olduktan sonra direkt olarak kayıt olma sayfasına yönlendiriyor.
![19](https://user-images.githubusercontent.com/79757076/129767294-7d219edd-8f21-4294-b2cd-2bca1c576951.png)
Kullanıcı hesabına girdikten sonra resimdeki gibi kullanıcın adı her ise hesap kısmında adı görünüyor.
![20](https://user-images.githubusercontent.com/79757076/129767397-d1bffd64-799d-4247-b63d-d6182f432f8f.png)
Eğer kayıtlı kullanıcı olarak siteye giriş yapıldıysa aşağıdaki gibi bir banner karşılayacak.
![21](https://user-images.githubusercontent.com/79757076/129767604-39cc5aa4-5d6a-43ee-a343-ee3ce066e403.png)
Kullanıcı sadece site içerisinde geziyorsa ve herhangi bir giriş yapmadıysa aşağıdaki gibi bir banner karşılıyor;
![22](https://user-images.githubusercontent.com/79757076/129767721-099651bc-74c6-45d0-93c0-e62512697181.png)
Eğer ki siteye admin olarak giriş yapıldıysa bannerın resimdeki gibi admin tarafında farklı seçenekleri olacak;
![23](https://user-images.githubusercontent.com/79757076/129767958-a41e3a38-72fd-4c23-9b85-868493f622a6.png)
Kullanıcı kendi hesabıyla girdiğinde sayfada detaylar ve sepete ekle seçeneği oluyor. Giriş yapılmadıysa ürün kartlarında sadece detaylar seçeneği oluyor. Detaylara tıkladığında kullanıcı sepete ekle seçeneğini görüyor. 
![26](https://user-images.githubusercontent.com/79757076/129769000-a0b0ec0e-e1ae-4cec-8593-c4974c0c269f.png)
Ürünü sepete eklemek istediğinde ise direkt olarak kullanıcı giriş sayfasına yönlendiriliyor ve giriş yaptıktan sonra seçilen ürün otomatikman sepete ekleniyor. Eğer ki kayıtlı bir kullanıcı değilse giriş yapma sayfasında yeni kayıt oluştur seçeneğine tıklayarak kaydını oluşturabilir.
![24](https://user-images.githubusercontent.com/79757076/129768805-8319d72d-1546-4712-9a5c-246ddc8ec8e2.png)
Yine ürün sayfasına geldiğimizde ise burada istediği üründen ne kadar isterse ürün miktarını seçip sepete ekleyebilir.
![25](https://user-images.githubusercontent.com/79757076/129768945-1bc13db2-529a-4425-8867-3207294a5e63.png)
Veritabanın da ise ürün ıd'sine göre cart ve miktar seçenekleri otomatik işliyor.
![27](https://user-images.githubusercontent.com/79757076/129769371-057fb8fe-0b39-4477-827c-f5f5a7efbd15.png)
Herhangi bir kullanıcının sepete eklediği ürünler ise aşağıdaki resimdeki gibi görünüyor.
![28](https://user-images.githubusercontent.com/79757076/129769455-8526399f-b087-4812-98f9-acf3aa5e9459.png)
Ürünün adı, resmi, fiyatı ve miktarı aynı zamanda sipariş toplamı da şekildeki gibi görünüyor.
![29](https://user-images.githubusercontent.com/79757076/129769631-20eb3e09-55ea-4da4-b5a0-30f1fc172a36.png)
Sepetim kısmında ise detayların en aşağısında ödeme kısmı var. Eğer ki alışverişe devam etmek istersek alışverişe devam et seçeneği ile tekrardan sitenin anasayfasına gidebiliyoruz.
![30](https://user-images.githubusercontent.com/79757076/129769790-7724ccbc-8baf-4c65-8fbc-923e3798dd38.png)

Projede hazır template kullanılmıştır. URL aşağıda verilmiştir:
https://www.free-css.com/free-css-templates/page261/lighten

Projede kullanılan resimler Pexels sitesinden alınmıştır. Site URL:
https://www.pexels.com/tr-tr/





Katmanlı mimari ve MVC kullanarak yaptığım bir E-Ticaret sitesidir.
