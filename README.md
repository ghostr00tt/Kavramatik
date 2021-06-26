# Kavramatik - Özel Gereksinimli Öğrenciler İçin Kavram Öğretimi
Genel Yapı

Çalışma Yapısı

Giriş ekranı ile karşılaşan kullanıcı kaydı varsa e-posta ve şifre ile, kaydı yoksa kayıt olarak veya kayıt olmadan sisteme erişim sağlayabilmektedir.Giriş ekranının ardından kullanıcı öğrenmek istediği kavrama ait kategoriyi seçecektir.Kategoriyi seçen kullanıcı kategoriye ait kavramların olduğu ekrana yönlendirilip, öğrenmek istediği kavramı(renk,boyut,yön,rakam vs.) seçtikten sonra 2 aşamalı bir öğrenim sürecine geçecektir.

İki aşamalı öğrenim modelinde ilk olarak kullanıcı seçtiği kavramı ve seçtiği kavramdan farklı bir kavramı 4 defa görecektir.Bu aşamada öğrenilen kavramın yeri sabit kalmayıp sürekli değişkenlik göstermektedir, bu sebepten ötürü kullanıcının ezbere hareketler sergilemesi ihtimali ortadan kaldırılmıştır.Yine bu aşamada istenilen kavrama tıklayan kullanıcı kavramın adını bir TipBox(Bilgilendirme Kutusu) ile görmekte ve ek olarak Text-To-Speech yardımı ile sesli bir şekilde duyabilmekte olup, seçtiği kavram olmayan öğeye tıkladığında ise "Bu kavram X değildir" şeklinde sesli bir yanıt almaktadır.Bu işlem 4 defa tekrar ettikten sonra kullanıcı ikinci aşama olan geri dönüş alınıp öğrenimin pekiştirilmesi kısmına geçmektedir.

İkinci kısımda kullanıcıdan bir önceki aşamada öğrendiği kavramı, o kavramla alakası olmayan bir kavramdan ayırt etmesi istenmektedir.Kavram ile alakası olmayan öğeye tıkladığında yine Text-To-Speech ile "Bu kavram X değildir" şeklinde geri dönüş yapılıp doğru kavrama tıkladığı takdirde bir MessageBox(Mesaj Kutusu) aracılığıyla "Harikasın" geri dönüşü yapılmaktadır ve bu süreç kendini 4 defa tekrar ettikten sonra kullanıcı ilgili kavramı tamamlamış kabul edilmektedir.Aynı kategoride başka bir kavrama geçtiğinde daha önce öğrendiği kavram karşısına geldiğinde bu sefer "Bu kavram X değildir" geri dönüşü yerine kavramın adı kullancıya sesli şekilde söylenmektedir, bu sayede daha önce öğretilen kavram tekrar gösterilerek öğrenimin pekiştirilmesi hedeflenmektedir.


Geliştirilme Ortamı

Uygulama Windows ortamında Visual Studio(2019) IDE ile C# programlama dili kullanarak .Net Framework ortamında geliştirilmiştir.

Veri tabanı seçiminde MySQL kullanılmış olup, uygulama ile veritabanı haberleşmesi Json metin biçimi kullanılmıştır.

Tasarım aşamasında ise Windows Forms öğelerinin günümüz tasarım öğelerine olan uyumluluğu düşük olmasından dolayı, Bunifu Tasarım Formlarından yararlanılarak gerek butonların, gerek metin kutularının ve diğer öğelerin daha modern bir görünüme sahip olması sağlanmıştır.

Kaynak kullanımı etkin şekilde yönetebilmek ve olası bellek taşmalarını önlemek için açılır pencereler oluşturulurken bir pencerenin açıldıktan sonra tekrar açılmaması için bir kontrol mekanizması sağlanmıştır, daha detaylı anlatacak olursak "Renkler" kategorisindeki kartları görüntülemek için ana ekranda "Renkler" kategorisine tıkladığında ilgili kategoriye ait kartlar kullanıcıya gösterilir, fakat kullanıcı bir tane daha "Renkler" sayfası açmak istediğinde bir tane daha pencere açılmaz, açık olan pencere öne çıkarılır.



Seslendirme

Seslendirme için Text-To-Speech yöntemine başvurulması proje süreci için uygun görüldüğünden ötürü System.Windows.Forms.WebBrowser kütüphanesi yardımıyla arka planda açılan bir tarayıcı yardımıyla bing translator kullanarak "https://www.bing.com/translator/?from=tr&to=en" URL'ine seslendirilmesi istenen string ifade parametre olarak gönderilip, ses şeklinde dönen yanıtı da kullanıcıya yansıtarak seslendirme işlemini gerçekleştirdik.Arka planda çalışan browserın gideceği url belirtilip,TR-EN çeviri sayfasında "tta_input_ta" parametresine(Türkçe İngilizce çeviri kısmında Türkçe metnin girildiği alan) seslendirmek istediğimiz metni veriyoruz ve oynat butonunu tetikleyerek Türkçe seslendirme işlemini gerçekleştiriyoruz.



Kategoriler

Proje kapsamında öğretilmesi hedeflenen kategoriler;

-Renkler

-Boyutlar

-Şekiller

-Miktarlar

-Yönler

-Sayılar

-Duyular

-Duygular

-Zıt Kavramlar

Olmak üzere 9 ayrı kategori şeklinde tasarlanmıştır.Kategori içeriklerine değinecek olursak ;

Renkler

Renkler kategorisinde kırmızı,mavi,sarı,turuncu,yeşil,mor,siyah,beyaz renkler bulunmaktadır.



Boyutlar

Boyutlar kategorisinde büyük-küçük,dar-geniş,ince-kalın,uzun-kısa boyutları bulunmaktadır.



Şekiller

Şekiller kategorisinde daire,kare,üçgen,dikdörtgen,elips şekilleri bulunmaktadır.



Miktarlar

Miktarlar kategorisinde az-çok,ağır-hafif,boş-dolu,bütün-çeyrek/yarım miktarları yer almaktadır



Yönler

Yönler kategorisinde önünde,arkasında,altında,içinde,üstünde,yanında yönleri bulunmaktadır.



Sayılar

Sayılar kategorisinde 0,1,2,3,4,5,6,7,8,9 rakamları yer almaktadır.



Duyular

Duyular kategorisinde tatlı,tuzlu,acı,ekşi,soğuk,sıcak duyuları yer almaktadır.



Duygular

Duygular kategorisinde mutlu,üzgün,kızgın,korkmuş,mutlu duyguları yer almaktadır.



Sistemin Çalışma Yapısı

Bu aşamada uygulama içerisinde gezinme işlemi ve ekranların işlevi anlatılacaktır.

Giriş



Üyeliği olan kullanıcı bilgileri ile giriş yapabilecek, üyeliği olmayan kullanıcı "Şimdi kayıt olun" yönlendirmesi aracılığıyla kayıt olabilecek, bunları talep etmeyen kullanıcı anonim olarak doğrudan uygulamaya erişim sağlayabilecektir.

Seçim Ekranı



Oyun – Eğitim yönlendirmesi bu alanda gerçekleştirilecektir.

Eğitim – Kategoriler



Kullanıcı bu aşamada eğitim görebileceği kavramları/kategorileri tanıyıp, istediği kategori ile devam edecektir.Fare imleci görsellerin üzerine gelindiğinde TipBox ile kategori adı yazdırılıp,görselin arka planı kırmızı rengi almaktadır.

Eğitim – Kavram



Kategorilerden "Renkler" kategorisi seçilmiştir, kategori seçildikten sonra istenilen kavrama tıklanması kullanıcıdan beklenmektedir.

Eğitim - Öğrenme



Kavram ekranında seçilen kavram ile birlikte eğitim aşamasına bir index numarası gönderilir ve index numarasına göre eğitim süreci şekillenir.

Bu örnekte "Kırmızı" rengi öğrenim için seçilmiştir.Olay örgüsüne değinecek olursak ilk olarak seçilen kavrama ait görsel, görselin üzerinde görselin ait olduğu kavramın adı, ikinci olarak da ilgili kavramdan farklı bir kavram ve "Bu kavram X değildir" şeklinde görünmektedir.Bu esnada görsellere tıklayan kullanıcı ilgili kavrama tıklarsa kavramın adını sesli olarak duyabilecektir, kavramdan farklı olan görsele tıkladığında ise yine sesli olarak " Bu kavram X değildir" şeklinde seslendirme duyacaktır.Bu adımlar 4 defa tekrar etmektedir ve seçilen kavramın yeri sabit olmayıp soldan başlayıp sağ-sol şeklinde yer değiştirmektedir.

Ek olarak bu örnekte kırmızı rengi tamamlayan kullanıcı, yeşil rengi öğrenmeye başladığında kırmızı rengi tamamladığı için artık "Bu kavram X değildir" sesini duymak yerine artık öğrendiği kavramın adını duyacaktır, böylelikle kullanıcının öğrendiği kavramı pekiştirmesi de hedeflenmektedir.



tekrar yapıldıktan sonra butonun üzerindeki "Sıradaki" yazısını "Alıştırmaya Geç" olarak değişmektedir ve butona tıklandığında artık kullanıcının seçmesini istediğimiz pekiştirme aşamasına geçilecektir.
Eğitim – Pekiştirme



Bu aşamada kullanıcı doğru görsele tıklamadan ilerlemeyecektir.Yanlış görsele tıkladığında "Bu kavram X değildir" sesi duyulacaktır.



Kullanıcı doğru seçimi yaptığında ise "Doğru kavramı buldun, harikasın" sesli yanıtı ile birlikte bir mesaj kutusu ekranda belirip yine yazılı olarak harikasın denilmektedir.Bu işlem 4 defa tekrarlanmaktadır.



Tamamlandığında ise kavramın tamamlandığını kullancıya yazılı olarak gösterip, ilgili yönlendirmelerle menüye dönüşü sağlanmaktadır.

Oyun – Kavram Eşleştirme



Görülen açılır pencere yardımıyla kullanıcı eşleştirme oyununda eşleştirmek istediği kavramı seçmektedir.Başla denildikten sonra seçim için kullanılan açılır pencere görünmez hale gelecektir.



Kavram eşleştirme oyununda bir kavram görselinden bir kavram görselinden 2 tane oluşturulup,rastgele yerleştirilen bu kavramların birbiri ile eşleştirilmesi istenmektedir.2 ayrı kavram olmak üzere toplamda 4 kart ile başlayan kullanıcı doğru eşleştirmeler ile verilen eşleştirmeleri bitirdikçe, eşleştirmesi istenen kart sayısı 2 şer olmak üzere arttırılmaktadır.Ayrıca her tamamlamada kullanıcının skor hanesine puan eklenmektedir.



3 ipucu hakkı bulunan kullanıcı ipucu butonuna tıkladığında 900ms(yaklaşık 1 saniye) kartların yerleşimini görebilmektedir.

Sonuç

Sonuç olarak bu proje ile birlikte özel gereksinimli öğrencilerin temel kavram öğrenimine doğrudan veya dolaylı olarak katkı sağlayacak yapı tasarlanmıştır.Tasarım öğeleri oldukça sade, uygulama içi hareketler ve etkileşimler oldukça basit kurgulanmıştır.

Doğru sonuçlar elde ettikçe kullanıcıya verilen yazılı ve sesli geri dönüşler ile kullanıcıyı çekmek hedeflenip, bütün sistem bunun üzerine kurgulanmıştır.Bunlara ek puan sisteminin de sistem içerisinde yer alması,bir öğretim merkezince kullanılması durumunda öğrencilerin kendi aralarında daha çok öğrenip daha çok puan alması için bir teşvik edici olması için planlanıp uygulamaya geçirilmiştir.


Ekran Görüntüleri 
![giriş](https://user-images.githubusercontent.com/61949486/123527185-0df64e80-d6e6-11eb-8551-505745c59212.JPG)
![seçimekrani](https://user-images.githubusercontent.com/61949486/123527196-1189d580-d6e6-11eb-8d18-66f7c54ab367.JPG)
______________________________________________________________________________________________________________________
![Kategoriler](https://user-images.githubusercontent.com/61949486/123527186-0e8ee500-d6e6-11eb-8c2c-dba01f955608.JPG)
![renkler](https://user-images.githubusercontent.com/61949486/123527194-10f13f00-d6e6-11eb-868a-5056c5382f1b.JPG)
![boyutlar](https://user-images.githubusercontent.com/61949486/123527178-0c2c8b00-d6e6-11eb-86e3-36883db1b158.JPG)
![miktarlar](https://user-images.githubusercontent.com/61949486/123527189-0f277b80-d6e6-11eb-8dd0-f8279dca3699.JPG)
![Duygular](https://user-images.githubusercontent.com/61949486/123527179-0c2c8b00-d6e6-11eb-8a3f-7baaf4eb46c2.JPG)
![Duyular](https://user-images.githubusercontent.com/61949486/123527180-0c2c8b00-d6e6-11eb-96ce-84e6e8769077.JPG)
![Sayılar](https://user-images.githubusercontent.com/61949486/123527195-1189d580-d6e6-11eb-9221-78fdff0b8e93.JPG)
![Şekiller](https://user-images.githubusercontent.com/61949486/123527198-1189d580-d6e6-11eb-9968-c8a3f6922f34.JPG)
![yönler](https://user-images.githubusercontent.com/61949486/123527199-12226c00-d6e6-11eb-8d80-4439b31aaae7.JPG)
![eğitim2](https://user-images.githubusercontent.com/61949486/123527182-0d5db800-d6e6-11eb-9102-4e414edf7f07.JPG)
![eğitim3](https://user-images.githubusercontent.com/61949486/123527183-0d5db800-d6e6-11eb-897b-13e74528223f.JPG)
![eğitim4](https://user-images.githubusercontent.com/61949486/123527184-0df64e80-d6e6-11eb-95aa-6e93bfc87590.JPG)
![alıştırma1](https://user-images.githubusercontent.com/61949486/123527175-0afb5e00-d6e6-11eb-9dd1-2c0ddeadb90d.JPG)
![alıştırma2](https://user-images.githubusercontent.com/61949486/123527176-0b93f480-d6e6-11eb-8257-5d29b3f4d35f.JPG)
![alıştırma3](https://user-images.githubusercontent.com/61949486/123527177-0b93f480-d6e6-11eb-914a-fd10107ab42b.JPG)
![oyun1](https://user-images.githubusercontent.com/61949486/123527190-0fc01200-d6e6-11eb-9719-4cc26c773596.JPG)
![oyunrenk](https://user-images.githubusercontent.com/61949486/123527191-0fc01200-d6e6-11eb-93b4-19f00ac1b04f.png)
![oyunrenk2](https://user-images.githubusercontent.com/61949486/123527193-1058a880-d6e6-11eb-9cc4-8a63d42857c3.JPG)


