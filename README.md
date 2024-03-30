# QuasarShop
E-Ticaret uygulamasıdır
- Katalog
- Ürün
- Sipariş
- Ödeme
- Üyelik

Özellikleri bulunur.
# Veri Modeli
- Catalog
  - Id
  - Name
    
- Product
  - Id
  - Name
  - Desc
  - Price
  - DiscountRate
  - Image
  
- User
- Role
- CarouselImage
  - Id
  - Image
  - StartDate
  - EndDate
 
- ShoppingCart
  - Id
  - UserId
  - ProductId
  - Quantity
    
- Order
  - Id
  - Date
  - UserId
  - CargoTrackingkNumber
    
- OrderDetail
  - Id
  - ProductId
  - Price
  - DiscountRate
  - Quantity
    
- UserAddress
  - Id
  - UserId
  - Name
  - Text
    
- ProductImages
  - Id
  - Image
  - ProductId
    
- Comments
  - Id
  - UserId
  - Text
  - Date
  - PrductId
  - Enabled
  - Rate
    
Bu projemizi kursta hocayla geliştirdik final projemizdi ve güzel şeyler öğrendik fakat bu açıklamada projenin eksik taraflarından bahsedeceğim.
Projenin mimarisi yanlış kurgulandığı için geliştirme sürecinde zorluklar önümüze çıktı. 
Final projemde 3 katmanlı mimari kullandım ve doğru şeyleri doğru yerlere koyunca projenin rahatlıkla yapılabildiğini gördüm.
Bu proje esnasında 3 katmanlı mimarı kullanırken iki katmanlı mimariye geçtik servisler web katmanının içerisine taşınmıştı.
Şahsen olması gerek viewmodellerin ya en alt katmana final projemdeki gibi ya da servis katmanında olmasıydı ve bu tüm problemleri çözerdi.
Çünkü business logic kısmı servislerde olup controllerda urle gelen isteğin değerlendirilmesindeki mantık var olmalıdır. Örneğin sayfalamada eğer sayfalama parametresi boş ise ona göre servis katmanına veri göndeririz ve o da bize çıktıyı gönderir. Ayrıca projenin apisi yapılacaksa bu bize kolaylık sağlar.
Bahsettiğim final projemin linki:
https://github.com/sadik-coban/EBookStore
Ayrıca sitenin performansı düşük. Burada kurguladığımız şey admin panelini az kişinin kullanacağı. Bu yüzden özel dtolara orada ihtiyaç olmayabilir fakat yinede sayfalama sistemine ihtiyaç vardır ve ürünlerimiz için sayfalama sistemi yaptık. Özellikle ana sayfada performansa önem vermek gerek bu süreçte farkettiğim ise bir dtoya veriyi doldururken Include() ihtiyaç olmaması. Sadece navigasyon özelliği ile örneğin ProductCatalogs bir dtonun özelliği ise ve atanan değer Product.Catalogs.Select(p=> p.Name).ToList() ise bunu include olmadan da sistem çözer ve implicit includedir ve sistem tüm catalog verisini hevesle yüklemez. Ancak include kullandığımız zaman tüm verileri hevesle yükler. Kendiniz deneyip sorguların çıktısını konsolda görebilirsiniz. Bunlara dikkat ederek final projemi geliştirdim ve performansta büyük bir artış gözlemledim.
