using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassicCars.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    Tumbnail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    createTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HeadCars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Tumbnail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeadCars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ImageGalleries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tumbnail = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageGalleries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PopularCars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Price = table.Column<decimal>(type: "MONEY", nullable: false),
                    Tumbnail = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PopularCars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parola = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tumbnail = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    createDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    Role = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VideoGalleries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VideoUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoGalleries", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Description", "IsActive", "Title", "Tumbnail" },
                values: new object[,]
                {
                    { 1, "Station Wagon (SW) ifadesinin Türkçe karşılığı “istasyon vagonu”, “istasyon kasası” şeklindedir. Tren istasyonlarında yük ve yolcu taşımak için kullanılan araçlardan ortaya çıkan bir araç türüdür. Aslında bir otomobil segmenti veya modelidir. Geniş ve uzun bagaj hacmi ile diğer otomobillerden ayrılan uzun araçlardır. Çatısı aracın arka ucuna kadar uzanır. Hatchbacklerin bagajı uzun, sedanların bagajı yüksek versiyonu da diyebiliriz. Genellikle 5 kapılı, yük taşıma kapasitesi yüksek otomobil türüdür. Arka koltukların arkasındaki geniş bagaj hacmi ile özellikle kalabalık aileler için ideal bir otomobildir. Birçok otomotiv firması, farklı model ve tasarımlarda station wagonlar üretiyor. Ancak ağırlığı ve yüksek yakıt tüketimi gibi faktörler sebebiyle pek tercih edilmeyen araçlardır. Daha doğrusu station wagonların müşterileri özeldir. Herkes station wagon kullanmak istemez; ancak bu modellerin tutkunları da başka araç kullanmaz. Amerika’da çok tercih edilen bir otomobildir. Bu sebeple “Amerika otomobili” olarak bilinir. Türkiye’de genellikle iş dünyasında rastlarız. Sanayilerde pratik bir yük taşıma aracı olarak yaygındır. Bazı iş kollarının vazgeçemediği bir tasarımdır. Kırsal kesimlerde daha sık tercih edilir. Türkler kısaca “steyşın” olarak adlandırır. Makalemizde station wagonların tarihini, diğer otomobillerden farklarını ve özelliklerini bulabilirsiniz.", true, "Station Wagon Nedir? (Tarihi, Özellikleri, Farkları)", "/Content/images/blog1.jpg" },
                    { 2, "Otomobil sahipleri ya da otomobil ile ilgilenenlerin çok yakından tanıdığı ve otomobil satın almak isteyenlerin de öğrenmesi gereken bir terim olan beygir gücü bir otomobilin süratini anlatmak için kullanılan genel bir terimdir. Bir otomobilin kaç beygir gücünde olduğunu bilmek için o otomobilin teknik özelliklerine bakmak gerekir. En baştan söylemekte fayda vardır ki beygir gücü ile anlatılmak istenen aslen otomobilin sahip olduğu motorun gücüdür. Bir motorun sahip olduğu beygir gücü zamanla değişmez. Beygir gücü teknik alanda kısaca BG şeklinde kullanılır ve İngilizce karşılığı Horsepower yani kısaltılmış hali olan HP olarak da karşınıza çıkabilir.Beygir gücünün birim olarak ne kadar güce karşılık geldiğini ise şu şekilde tanımlayabiliriz: Bir beygir gücü 75 kg’lik ağırlığı 1 saniye içerisinde 1 metrelik yüksekliğe çıkarabilecek güç miktarı olarak hesaplanmaktadır.Bu gücün tahmini olarak bir atın gücüne denk geldiği göz önüne anılarak bu güç hesaplaması için beygir gücü tanımı kullanılmaya başlanmıştır.Her ne kadar beygir gücü değiştirilemez olsa da yazımızın ilerleyen bölümlerinde anlatacağımız gibi tork yapısı itibarı ile otomobillerin beygir güçlerinin farklı şekillerde  de kullanılabileceği bilinmelidir.Burada  bahsi geçen ise otomobilin aslen bir dinametre yardımı ile ölçülüp hesaplanan beygir gücü ve tork değerleri; aktarma organı, vites kutusu ve tekerlek çapı gibi değişkenlere göre farklılık gösterebilecegidir.Örnek vermek gerekirse bir otomobilin motorunda bulunan dişli oranı ayarlarını değiştirerek bu otomobilin beygir gücü ve tork değerlerini farklılaştırmak mümkündür. Buradan da anlaşılacağı üzere her ne kadar beygir gücü ve tork değerleri değiştirilemez olsalar da bir otomobilin sahip olduğu güç, motorun kuvvetinin tekerleklere varıncaya kadar geçtiği düzeneklerin değiştirilmesi ile farklı boyutlara taşınabilir.", true, "Tork Nedir, Beygir Gücünden Farkı Nedir, Nasıl Hesaplanır?)", "/Content/images/blog2.jpg" },
                    { 3, "Radyal motorlar, içten yanmalı olarak sınıflandırılır. Çoğunlukla uçaklarda kullanılır. Silindirleri rotary (dönen) motorlarda olduğu gibi krank milinin etrafında bir daire oluşturacak şekilde dizilmiştir. Başka bir ifadeyle, silindirleri belli bir sıra dahilinde değil, daire merkezine karşı sıralanmış motor tipidir. Bu sebeple yıldız şeklinde görünümü vardır. Tüm piston kolları (biyel) göbekteki tek bir biyel muylusuna bağlıdır. Silindirler, krank milinin etrafında yıldız şeklinde devinimini tamamlar. Her silindirde bulunan pistonun hareketi, piston kolu (biyel) ve biyel muylusu yardımı ile krank miline aktarılır. Silindirlerin eksenlerinin aynı düzlemde olması nedeniyle, birleştirici çubuklar doğrudan krank miline bağlanamazlar. Bunun yerine, pistonlar krank miline bir mafsallı çubuk grubu ile bağlanırlar. Böylece krank milinin ekseni etrafında dönmesi sağlanır. Bu işlem, her pistonun hareketi ile sürekli tekrarlanır. Karbüratör ve gaz kolu yardımı ile motorun devri ayarlanır.Radyal motorda pistonlar,    biyeller yardımı ile krank miline bağlandır.Dört zamanı(emme, sıkıştırma, güç(yanma), egzoz) tamamlandığında krank mili iki devir yapar.Silindirler,ateşleme sırasına göre güç üretir.Yanan hava - yakıt karışımının patlaması ile meydana gelen güç,piston kolları vasıtası ile krank miline dönme hareketi olarak iletilir.Çalışma sistemi,bu bakımdan sıralı motorlarla benzer.Ateşleme sıraları farklıdır.Dokuz silindirli bir radyal motorda ateşleme sırası “1,3,5,7,9,2,4,6,8” numaralı silindirlerde bu sıraya göre gerçekleşir.Her çevrim tamamlandığında ateşleme sırası tekrar birinci silindire döner.Başka bir ifade ile pistondaki gücün hareketi sırasında ateşlenecek bir sonraki piston arasında bir piston vardır.Ateşleme sırası,valfların açılması ve kapanması,yanma sonrası oluşan gücün bir sonraki silindirin sıkıştırma işlemine yardım etmesi ve hareketin bu şekilde devam etmesi şekilde çevrim veya dört zaman tamamlanır.Radyal motorlarda tek sayılı silindirler kullanılmasının bir mantığı var.Motorun daha sorunsuz çalışması için tutarlı ve devamlı bir güç üretilmelidir.Daha verimli güç üretmek için tek sayıda silindir kullanılır.Böylece diğer piston ateşleme işlemini başarabilir.Eğer eşit sayıda silindir kullanılırsa,eşit derecede zamanlanmış bir ateşleme döngüsü mümkün olmazdı.Radyal motorlarda,otomobil ve motosikletlerde kullanılan motorların aksine silindirlerin ekseni aynı düzlemlidir.Dolayısıyla tipik eksantrik mili,emme ve egzoz valflarının kontrolü için kullanılamaz veya krank mili güç sunmaz.Bunun yerine,pistonlar mafsallı çubuk birleşimi ile krank miline bağlanır.Radyal motorların silindirleri üzerinde genelde “popet” adı verilen türde valflar kullanılır.Bu valflar,krank milinden zıt yönde dönen kam plakası tarafından kontrol edilen itme çubukları tarafından hareket ettirilir.Kam,dişli bir mekanizma yardımıyla döndürülür.", true, "Tork Nedir, Beygir Gücünden Farkı Nedir, Nasıl Hesaplanır?)", "/Content/images/blog2.jpg" },
                    { 4, "Cip, Türk Dil Kurumu’na göre, “her türlü arazide kullanılabilen motorlu taşıt”tır. Türkçe okunuşu ve yazılışı “cip” şeklinde olması gerekirken; -galat-ı meşhur olarak- “jeep” olarak yazılır, “jip” olarak okunur. Yani uzun süre yanlış kullanıldığı için halk arasında “jip” olarak yer edinmiştir. İlk olarak askeri amaçlarla üretilen cipler, günümüzde lüks ve konforun simgesi bir araç haline geldi. Bazen safari ve arazi aracı, bazen makam aracı olabilen cipler, “büyük otomobil” sınıfında anılır. SUV ve Crossover gibi büyük ve heybetli araçların çıkış noktası da ciplerdir. Artık prestij ve zenginliğin bir simgesi haline gelen cipler, geniş bir görüş açısı ve güvenli bir sürüş keyfi sunan araçlardır. Konfor ve rahatlık için sayısız özellik barındırırlar. “Jeep” dünya çapında cipleri temsil eden prestijli bir arazi aracı markasıdır. Ancak birçok otomotiv firması artık yeni nesil cipleri müşterilerine sunuyor. Cipler, çoğunlukla arazi koşullarına uygun olarak 4x4 yani dört tekerlekten çekiş özellikli üretilir. Segmentinde bulunan araç türlerinin en pahalısı cipler diyebiliriz. Tabi model ve markasına göre fiyatlar da farklılık gösterebilir. Yüksekliği, geniş iç hacmi ve gösterişli karoseri ile herkesin sahip olmak isteyeceği türden bir araç olan ciplere mercek tutalım!", true, "Cip (Jeep) Nedir? (Tarihi, Özellikleri))", "/Content/images/blog2.jpg" }
                });

            migrationBuilder.InsertData(
                table: "HeadCars",
                columns: new[] { "Id", "IsActive", "Title", "Tumbnail" },
                values: new object[] { 1, true, "CLASSIC CARS", "car-section1.png" });

            migrationBuilder.InsertData(
                table: "ImageGalleries",
                columns: new[] { "Id", "IsActive", "Tumbnail" },
                values: new object[,]
                {
                    { 1, true, "gallery-car-1.jpg" },
                    { 2, true, "gallery-car-2.jpg" },
                    { 3, true, "gallery-car-3.jpg" },
                    { 4, true, "gallery-car-4.jpg" },
                    { 5, true, "gallery-car-5.jpg" },
                    { 6, true, "gallery-car-6.jpg" }
                });

            migrationBuilder.InsertData(
                table: "PopularCars",
                columns: new[] { "Id", "IsActive", "Name", "Price", "Tumbnail" },
                values: new object[,]
                {
                    { 3, true, "CAR NAME", 150m, "car-3.jpg" },
                    { 1, true, "CAR NAME", 200m, "car-1.jpg" },
                    { 2, true, "CAR NAME", 100m, "car-2.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "LastName", "Name", "Parola", "Role", "Tumbnail" },
                values: new object[,]
                {
                    { 1, "ahmet.karakaya99@erzurum.edu.tr", "Karakaya", "Ahmet Burak", "123456", 1, "~/Content/images/etulogo1.png" },
                    { 2, "melih.karakaya@example.com.tr", "Karakaya", "Melih", "123456", 1, "~/Content/images/etulogo1.png" },
                    { 3, "zeynep.karakaya@example.com.tr", "Karakaya", "Zeynep", "123456", 1, "~/Content/images/etulogo1.png" }
                });

            migrationBuilder.InsertData(
                table: "VideoGalleries",
                columns: new[] { "Id", "IsActive", "VideoUrl" },
                values: new object[,]
                {
                    { 5, true, "car-video-5.mp4" },
                    { 1, true, "car-video-1.mp4" },
                    { 2, true, "car-video-2.mp4" },
                    { 3, true, "car-video-3.mp4" },
                    { 4, true, "car-video-4.mp4" },
                    { 6, true, "car-video-6.mp4" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "HeadCars");

            migrationBuilder.DropTable(
                name: "ImageGalleries");

            migrationBuilder.DropTable(
                name: "PopularCars");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "VideoGalleries");
        }
    }
}
