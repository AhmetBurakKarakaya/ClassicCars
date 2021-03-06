// <auto-generated />
using System;
using ClassicCars.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClassicCars.Migrations
{
    [DbContext(typeof(ClassicCarsContext))]
    [Migration("20220509172141_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ClassicCars.Data.Entities.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Tumbnail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("createTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.HasKey("Id");

                    b.ToTable("Blogs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Station Wagon (SW) ifadesinin Türkçe karşılığı “istasyon vagonu”, “istasyon kasası” şeklindedir. Tren istasyonlarında yük ve yolcu taşımak için kullanılan araçlardan ortaya çıkan bir araç türüdür. Aslında bir otomobil segmenti veya modelidir. Geniş ve uzun bagaj hacmi ile diğer otomobillerden ayrılan uzun araçlardır. Çatısı aracın arka ucuna kadar uzanır. Hatchbacklerin bagajı uzun, sedanların bagajı yüksek versiyonu da diyebiliriz. Genellikle 5 kapılı, yük taşıma kapasitesi yüksek otomobil türüdür. Arka koltukların arkasındaki geniş bagaj hacmi ile özellikle kalabalık aileler için ideal bir otomobildir. Birçok otomotiv firması, farklı model ve tasarımlarda station wagonlar üretiyor. Ancak ağırlığı ve yüksek yakıt tüketimi gibi faktörler sebebiyle pek tercih edilmeyen araçlardır. Daha doğrusu station wagonların müşterileri özeldir. Herkes station wagon kullanmak istemez; ancak bu modellerin tutkunları da başka araç kullanmaz. Amerika’da çok tercih edilen bir otomobildir. Bu sebeple “Amerika otomobili” olarak bilinir. Türkiye’de genellikle iş dünyasında rastlarız. Sanayilerde pratik bir yük taşıma aracı olarak yaygındır. Bazı iş kollarının vazgeçemediği bir tasarımdır. Kırsal kesimlerde daha sık tercih edilir. Türkler kısaca “steyşın” olarak adlandırır. Makalemizde station wagonların tarihini, diğer otomobillerden farklarını ve özelliklerini bulabilirsiniz.",
                            IsActive = true,
                            Title = "Station Wagon Nedir? (Tarihi, Özellikleri, Farkları)",
                            Tumbnail = "/Content/images/blog1.jpg",
                            createTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Description = "Otomobil sahipleri ya da otomobil ile ilgilenenlerin çok yakından tanıdığı ve otomobil satın almak isteyenlerin de öğrenmesi gereken bir terim olan beygir gücü bir otomobilin süratini anlatmak için kullanılan genel bir terimdir. Bir otomobilin kaç beygir gücünde olduğunu bilmek için o otomobilin teknik özelliklerine bakmak gerekir. En baştan söylemekte fayda vardır ki beygir gücü ile anlatılmak istenen aslen otomobilin sahip olduğu motorun gücüdür. Bir motorun sahip olduğu beygir gücü zamanla değişmez. Beygir gücü teknik alanda kısaca BG şeklinde kullanılır ve İngilizce karşılığı Horsepower yani kısaltılmış hali olan HP olarak da karşınıza çıkabilir.Beygir gücünün birim olarak ne kadar güce karşılık geldiğini ise şu şekilde tanımlayabiliriz: Bir beygir gücü 75 kg’lik ağırlığı 1 saniye içerisinde 1 metrelik yüksekliğe çıkarabilecek güç miktarı olarak hesaplanmaktadır.Bu gücün tahmini olarak bir atın gücüne denk geldiği göz önüne anılarak bu güç hesaplaması için beygir gücü tanımı kullanılmaya başlanmıştır.Her ne kadar beygir gücü değiştirilemez olsa da yazımızın ilerleyen bölümlerinde anlatacağımız gibi tork yapısı itibarı ile otomobillerin beygir güçlerinin farklı şekillerde  de kullanılabileceği bilinmelidir.Burada  bahsi geçen ise otomobilin aslen bir dinametre yardımı ile ölçülüp hesaplanan beygir gücü ve tork değerleri; aktarma organı, vites kutusu ve tekerlek çapı gibi değişkenlere göre farklılık gösterebilecegidir.Örnek vermek gerekirse bir otomobilin motorunda bulunan dişli oranı ayarlarını değiştirerek bu otomobilin beygir gücü ve tork değerlerini farklılaştırmak mümkündür. Buradan da anlaşılacağı üzere her ne kadar beygir gücü ve tork değerleri değiştirilemez olsalar da bir otomobilin sahip olduğu güç, motorun kuvvetinin tekerleklere varıncaya kadar geçtiği düzeneklerin değiştirilmesi ile farklı boyutlara taşınabilir.",
                            IsActive = true,
                            Title = "Tork Nedir, Beygir Gücünden Farkı Nedir, Nasıl Hesaplanır?)",
                            Tumbnail = "/Content/images/blog2.jpg",
                            createTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Description = "Radyal motorlar, içten yanmalı olarak sınıflandırılır. Çoğunlukla uçaklarda kullanılır. Silindirleri rotary (dönen) motorlarda olduğu gibi krank milinin etrafında bir daire oluşturacak şekilde dizilmiştir. Başka bir ifadeyle, silindirleri belli bir sıra dahilinde değil, daire merkezine karşı sıralanmış motor tipidir. Bu sebeple yıldız şeklinde görünümü vardır. Tüm piston kolları (biyel) göbekteki tek bir biyel muylusuna bağlıdır. Silindirler, krank milinin etrafında yıldız şeklinde devinimini tamamlar. Her silindirde bulunan pistonun hareketi, piston kolu (biyel) ve biyel muylusu yardımı ile krank miline aktarılır. Silindirlerin eksenlerinin aynı düzlemde olması nedeniyle, birleştirici çubuklar doğrudan krank miline bağlanamazlar. Bunun yerine, pistonlar krank miline bir mafsallı çubuk grubu ile bağlanırlar. Böylece krank milinin ekseni etrafında dönmesi sağlanır. Bu işlem, her pistonun hareketi ile sürekli tekrarlanır. Karbüratör ve gaz kolu yardımı ile motorun devri ayarlanır.Radyal motorda pistonlar,    biyeller yardımı ile krank miline bağlandır.Dört zamanı(emme, sıkıştırma, güç(yanma), egzoz) tamamlandığında krank mili iki devir yapar.Silindirler,ateşleme sırasına göre güç üretir.Yanan hava - yakıt karışımının patlaması ile meydana gelen güç,piston kolları vasıtası ile krank miline dönme hareketi olarak iletilir.Çalışma sistemi,bu bakımdan sıralı motorlarla benzer.Ateşleme sıraları farklıdır.Dokuz silindirli bir radyal motorda ateşleme sırası “1,3,5,7,9,2,4,6,8” numaralı silindirlerde bu sıraya göre gerçekleşir.Her çevrim tamamlandığında ateşleme sırası tekrar birinci silindire döner.Başka bir ifade ile pistondaki gücün hareketi sırasında ateşlenecek bir sonraki piston arasında bir piston vardır.Ateşleme sırası,valfların açılması ve kapanması,yanma sonrası oluşan gücün bir sonraki silindirin sıkıştırma işlemine yardım etmesi ve hareketin bu şekilde devam etmesi şekilde çevrim veya dört zaman tamamlanır.Radyal motorlarda tek sayılı silindirler kullanılmasının bir mantığı var.Motorun daha sorunsuz çalışması için tutarlı ve devamlı bir güç üretilmelidir.Daha verimli güç üretmek için tek sayıda silindir kullanılır.Böylece diğer piston ateşleme işlemini başarabilir.Eğer eşit sayıda silindir kullanılırsa,eşit derecede zamanlanmış bir ateşleme döngüsü mümkün olmazdı.Radyal motorlarda,otomobil ve motosikletlerde kullanılan motorların aksine silindirlerin ekseni aynı düzlemlidir.Dolayısıyla tipik eksantrik mili,emme ve egzoz valflarının kontrolü için kullanılamaz veya krank mili güç sunmaz.Bunun yerine,pistonlar mafsallı çubuk birleşimi ile krank miline bağlanır.Radyal motorların silindirleri üzerinde genelde “popet” adı verilen türde valflar kullanılır.Bu valflar,krank milinden zıt yönde dönen kam plakası tarafından kontrol edilen itme çubukları tarafından hareket ettirilir.Kam,dişli bir mekanizma yardımıyla döndürülür.",
                            IsActive = true,
                            Title = "Tork Nedir, Beygir Gücünden Farkı Nedir, Nasıl Hesaplanır?)",
                            Tumbnail = "/Content/images/blog2.jpg",
                            createTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Description = "Cip, Türk Dil Kurumu’na göre, “her türlü arazide kullanılabilen motorlu taşıt”tır. Türkçe okunuşu ve yazılışı “cip” şeklinde olması gerekirken; -galat-ı meşhur olarak- “jeep” olarak yazılır, “jip” olarak okunur. Yani uzun süre yanlış kullanıldığı için halk arasında “jip” olarak yer edinmiştir. İlk olarak askeri amaçlarla üretilen cipler, günümüzde lüks ve konforun simgesi bir araç haline geldi. Bazen safari ve arazi aracı, bazen makam aracı olabilen cipler, “büyük otomobil” sınıfında anılır. SUV ve Crossover gibi büyük ve heybetli araçların çıkış noktası da ciplerdir. Artık prestij ve zenginliğin bir simgesi haline gelen cipler, geniş bir görüş açısı ve güvenli bir sürüş keyfi sunan araçlardır. Konfor ve rahatlık için sayısız özellik barındırırlar. “Jeep” dünya çapında cipleri temsil eden prestijli bir arazi aracı markasıdır. Ancak birçok otomotiv firması artık yeni nesil cipleri müşterilerine sunuyor. Cipler, çoğunlukla arazi koşullarına uygun olarak 4x4 yani dört tekerlekten çekiş özellikli üretilir. Segmentinde bulunan araç türlerinin en pahalısı cipler diyebiliriz. Tabi model ve markasına göre fiyatlar da farklılık gösterebilir. Yüksekliği, geniş iç hacmi ve gösterişli karoseri ile herkesin sahip olmak isteyeceği türden bir araç olan ciplere mercek tutalım!",
                            IsActive = true,
                            Title = "Cip (Jeep) Nedir? (Tarihi, Özellikleri))",
                            Tumbnail = "/Content/images/blog2.jpg",
                            createTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("ClassicCars.Data.Entities.HeadCars", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tumbnail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HeadCars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsActive = true,
                            Title = "CLASSIC CARS",
                            Tumbnail = "car-section1.png"
                        });
                });

            modelBuilder.Entity("ClassicCars.Data.Entities.ImageGallery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Tumbnail")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("ImageGalleries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsActive = true,
                            Tumbnail = "gallery-car-1.jpg"
                        },
                        new
                        {
                            Id = 2,
                            IsActive = true,
                            Tumbnail = "gallery-car-2.jpg"
                        },
                        new
                        {
                            Id = 3,
                            IsActive = true,
                            Tumbnail = "gallery-car-3.jpg"
                        },
                        new
                        {
                            Id = 4,
                            IsActive = true,
                            Tumbnail = "gallery-car-4.jpg"
                        },
                        new
                        {
                            Id = 5,
                            IsActive = true,
                            Tumbnail = "gallery-car-5.jpg"
                        },
                        new
                        {
                            Id = 6,
                            IsActive = true,
                            Tumbnail = "gallery-car-6.jpg"
                        });
                });

            modelBuilder.Entity("ClassicCars.Data.Entities.PopularCars", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<decimal>("Price")
                        .HasColumnType("MONEY");

                    b.Property<string>("Tumbnail")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("PopularCars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsActive = true,
                            Name = "CAR NAME",
                            Price = 200m,
                            Tumbnail = "car-1.jpg"
                        },
                        new
                        {
                            Id = 2,
                            IsActive = true,
                            Name = "CAR NAME",
                            Price = 100m,
                            Tumbnail = "car-2.jpg"
                        },
                        new
                        {
                            Id = 3,
                            IsActive = true,
                            Name = "CAR NAME",
                            Price = 150m,
                            Tumbnail = "car-3.jpg"
                        });
                });

            modelBuilder.Entity("ClassicCars.Data.Entities.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Parola")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("Tumbnail")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<DateTime>("createDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "ahmet.karakaya99@erzurum.edu.tr",
                            LastName = "Karakaya",
                            Name = "Ahmet Burak",
                            Parola = "123456",
                            Role = 1,
                            Tumbnail = "~/Content/images/etulogo1.png",
                            createDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Email = "melih.karakaya@example.com.tr",
                            LastName = "Karakaya",
                            Name = "Melih",
                            Parola = "123456",
                            Role = 1,
                            Tumbnail = "~/Content/images/etulogo1.png",
                            createDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Email = "zeynep.karakaya@example.com.tr",
                            LastName = "Karakaya",
                            Name = "Zeynep",
                            Parola = "123456",
                            Role = 1,
                            Tumbnail = "~/Content/images/etulogo1.png",
                            createDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("ClassicCars.Data.Entities.VideoGallery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("VideoUrl")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("VideoGalleries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsActive = true,
                            VideoUrl = "car-video-1.mp4"
                        },
                        new
                        {
                            Id = 2,
                            IsActive = true,
                            VideoUrl = "car-video-2.mp4"
                        },
                        new
                        {
                            Id = 3,
                            IsActive = true,
                            VideoUrl = "car-video-3.mp4"
                        },
                        new
                        {
                            Id = 4,
                            IsActive = true,
                            VideoUrl = "car-video-4.mp4"
                        },
                        new
                        {
                            Id = 5,
                            IsActive = true,
                            VideoUrl = "car-video-5.mp4"
                        },
                        new
                        {
                            Id = 6,
                            IsActive = true,
                            VideoUrl = "car-video-6.mp4"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
