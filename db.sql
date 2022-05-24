/*
Navicat SQL Server Data Transfer

Source Server         : DESKTOP-NCQDMP0
Source Server Version : 150000
Source Host           : DESKTOP-NCQDMP0:1433
Source Database       : CLASSICCARSDB
Source Schema         : dbo

Target Server Type    : SQL Server
Target Server Version : 100000
File Encoding         : 65001

Date: 2022-05-21 16:29:21
*/


-- ----------------------------
-- Table structure for [__EFMigrationsHistory]
-- ----------------------------
DROP TABLE [__EFMigrationsHistory]
GO
CREATE TABLE [__EFMigrationsHistory] (
[MigrationId] nvarchar(150) NOT NULL ,
[ProductVersion] nvarchar(32) NOT NULL 
)


GO

-- ----------------------------
-- Records of __EFMigrationsHistory
-- ----------------------------
BEGIN TRANSACTION
GO
INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220509172141_InitialCreate', N'5.0.0');
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for [Blogs]
-- ----------------------------
DROP TABLE [Blogs]
GO
CREATE TABLE [Blogs] (
[Id] int NOT NULL IDENTITY(1,1) ,
[Title] nvarchar(250) NOT NULL ,
[Description] nvarchar(MAX) NOT NULL ,
[Tumbnail] nvarchar(MAX) NOT NULL ,
[IsActive] bit NOT NULL ,
[createTime] datetime2(7) NOT NULL DEFAULT (getdate()) 
)


GO
DBCC CHECKIDENT(N'[Blogs]', RESEED, 1004)
GO

-- ----------------------------
-- Records of Blogs
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [Blogs] ON
GO
INSERT INTO [Blogs] ([Id], [Title], [Description], [Tumbnail], [IsActive], [createTime]) VALUES (N'1', N'Station Wagon Nedir? (Tarihi, Özellikleri, Farkları)', N'Station Wagon (SW) ifadesinin Türkçe karşılığı “istasyon vagonu”, “istasyon kasası” şeklindedir. Tren istasyonlarında yük ve yolcu taşımak için kullanılan araçlardan ortaya çıkan bir araç türüdür. Aslında bir otomobil segmenti veya modelidir. Geniş ve uzun bagaj hacmi ile diğer otomobillerden ayrılan uzun araçlardır. Çatısı aracın arka ucuna kadar uzanır. Hatchbacklerin bagajı uzun, sedanların bagajı yüksek versiyonu da diyebiliriz. Genellikle 5 kapılı, yük taşıma kapasitesi yüksek otomobil türüdür. Arka koltukların arkasındaki geniş bagaj hacmi ile özellikle kalabalık aileler için ideal bir otomobildir. Birçok otomotiv firması, farklı model ve tasarımlarda station wagonlar üretiyor. Ancak ağırlığı ve yüksek yakıt tüketimi gibi faktörler sebebiyle pek tercih edilmeyen araçlardır. Daha doğrusu station wagonların müşterileri özeldir. Herkes station wagon kullanmak istemez; ancak bu modellerin tutkunları da başka araç kullanmaz. Amerika’da çok tercih edilen bir otomobildir. Bu sebeple “Amerika otomobili” olarak bilinir. Türkiye’de genellikle iş dünyasında rastlarız. Sanayilerde pratik bir yük taşıma aracı olarak yaygındır. Bazı iş kollarının vazgeçemediği bir tasarımdır. Kırsal kesimlerde daha sık tercih edilir. Türkler kısaca “steyşın” olarak adlandırır. Makalemizde station wagonların tarihini, diğer otomobillerden farklarını ve özelliklerini bulabilirsiniz.', N'/Content/images/blog1.jpg', N'1', N'2022-05-09 20:21:52.3500000');
INSERT INTO [Blogs] ([Id], [Title], [Description], [Tumbnail], [IsActive], [createTime]) VALUES (N'2', N'Tork Nedir, Beygir Gücünden Farkı Nedir, Nasıl Hesaplanır?)', N'Otomobil sahipleri ya da otomobil ile ilgilenenlerin çok yakından tanıdığı ve otomobil satın almak isteyenlerin de öğrenmesi gereken bir terim olan beygir gücü bir otomobilin süratini anlatmak için kullanılan genel bir terimdir. Bir otomobilin kaç beygir gücünde olduğunu bilmek için o otomobilin teknik özelliklerine bakmak gerekir. En baştan söylemekte fayda vardır ki beygir gücü ile anlatılmak istenen aslen otomobilin sahip olduğu motorun gücüdür. Bir motorun sahip olduğu beygir gücü zamanla değişmez. Beygir gücü teknik alanda kısaca BG şeklinde kullanılır ve İngilizce karşılığı Horsepower yani kısaltılmış hali olan HP olarak da karşınıza çıkabilir.Beygir gücünün birim olarak ne kadar güce karşılık geldiğini ise şu şekilde tanımlayabiliriz: Bir beygir gücü 75 kg’lik ağırlığı 1 saniye içerisinde 1 metrelik yüksekliğe çıkarabilecek güç miktarı olarak hesaplanmaktadır.Bu gücün tahmini olarak bir atın gücüne denk geldiği göz önüne anılarak bu güç hesaplaması için beygir gücü tanımı kullanılmaya başlanmıştır.Her ne kadar beygir gücü değiştirilemez olsa da yazımızın ilerleyen bölümlerinde anlatacağımız gibi tork yapısı itibarı ile otomobillerin beygir güçlerinin farklı şekillerde  de kullanılabileceği bilinmelidir.Burada  bahsi geçen ise otomobilin aslen bir dinametre yardımı ile ölçülüp hesaplanan beygir gücü ve tork değerleri; aktarma organı, vites kutusu ve tekerlek çapı gibi değişkenlere göre farklılık gösterebilecegidir.Örnek vermek gerekirse bir otomobilin motorunda bulunan dişli oranı ayarlarını değiştirerek bu otomobilin beygir gücü ve tork değerlerini farklılaştırmak mümkündür. Buradan da anlaşılacağı üzere her ne kadar beygir gücü ve tork değerleri değiştirilemez olsalar da bir otomobilin sahip olduğu güç, motorun kuvvetinin tekerleklere varıncaya kadar geçtiği düzeneklerin değiştirilmesi ile farklı boyutlara taşınabilir.', N'/Content/images/blog2.jpg', N'1', N'2022-05-09 20:21:52.3500000');
INSERT INTO [Blogs] ([Id], [Title], [Description], [Tumbnail], [IsActive], [createTime]) VALUES (N'3', N'Tork Nedir, Beygir Gücünden Farkı Nedir, Nasıl Hesaplanır?)', N'Radyal motorlar, içten yanmalı olarak sınıflandırılır. Çoğunlukla uçaklarda kullanılır. Silindirleri rotary (dönen) motorlarda olduğu gibi krank milinin etrafında bir daire oluşturacak şekilde dizilmiştir. Başka bir ifadeyle, silindirleri belli bir sıra dahilinde değil, daire merkezine karşı sıralanmış motor tipidir. Bu sebeple yıldız şeklinde görünümü vardır. Tüm piston kolları (biyel) göbekteki tek bir biyel muylusuna bağlıdır. Silindirler, krank milinin etrafında yıldız şeklinde devinimini tamamlar. Her silindirde bulunan pistonun hareketi, piston kolu (biyel) ve biyel muylusu yardımı ile krank miline aktarılır. Silindirlerin eksenlerinin aynı düzlemde olması nedeniyle, birleştirici çubuklar doğrudan krank miline bağlanamazlar. Bunun yerine, pistonlar krank miline bir mafsallı çubuk grubu ile bağlanırlar. Böylece krank milinin ekseni etrafında dönmesi sağlanır. Bu işlem, her pistonun hareketi ile sürekli tekrarlanır. Karbüratör ve gaz kolu yardımı ile motorun devri ayarlanır.Radyal motorda pistonlar,    biyeller yardımı ile krank miline bağlandır.Dört zamanı(emme, sıkıştırma, güç(yanma), egzoz) tamamlandığında krank mili iki devir yapar.Silindirler,ateşleme sırasına göre güç üretir.Yanan hava - yakıt karışımının patlaması ile meydana gelen güç,piston kolları vasıtası ile krank miline dönme hareketi olarak iletilir.Çalışma sistemi,bu bakımdan sıralı motorlarla benzer.Ateşleme sıraları farklıdır.Dokuz silindirli bir radyal motorda ateşleme sırası “1,3,5,7,9,2,4,6,8” numaralı silindirlerde bu sıraya göre gerçekleşir.Her çevrim tamamlandığında ateşleme sırası tekrar birinci silindire döner.Başka bir ifade ile pistondaki gücün hareketi sırasında ateşlenecek bir sonraki piston arasında bir piston vardır.Ateşleme sırası,valfların açılması ve kapanması,yanma sonrası oluşan gücün bir sonraki silindirin sıkıştırma işlemine yardım etmesi ve hareketin bu şekilde devam etmesi şekilde çevrim veya dört zaman tamamlanır.Radyal motorlarda tek sayılı silindirler kullanılmasının bir mantığı var.Motorun daha sorunsuz çalışması için tutarlı ve devamlı bir güç üretilmelidir.Daha verimli güç üretmek için tek sayıda silindir kullanılır.Böylece diğer piston ateşleme işlemini başarabilir.Eğer eşit sayıda silindir kullanılırsa,eşit derecede zamanlanmış bir ateşleme döngüsü mümkün olmazdı.Radyal motorlarda,otomobil ve motosikletlerde kullanılan motorların aksine silindirlerin ekseni aynı düzlemlidir.Dolayısıyla tipik eksantrik mili,emme ve egzoz valflarının kontrolü için kullanılamaz veya krank mili güç sunmaz.Bunun yerine,pistonlar mafsallı çubuk birleşimi ile krank miline bağlanır.Radyal motorların silindirleri üzerinde genelde “popet” adı verilen türde valflar kullanılır.Bu valflar,krank milinden zıt yönde dönen kam plakası tarafından kontrol edilen itme çubukları tarafından hareket ettirilir.Kam,dişli bir mekanizma yardımıyla döndürülür.', N'/Content/images/blog3.jpg', N'1', N'2022-05-09 20:21:52.3500000');
INSERT INTO [Blogs] ([Id], [Title], [Description], [Tumbnail], [IsActive], [createTime]) VALUES (N'4', N'Cip (Jeep) Nedir? (Tarihi, Özellikleri))', N'Cip, Türk Dil Kurumu’na göre, “her türlü arazide kullanılabilen motorlu taşıt”tır. Türkçe okunuşu ve yazılışı “cip” şeklinde olması gerekirken; -galat-ı meşhur olarak- “jeep” olarak yazılır, “jip” olarak okunur. Yani uzun süre yanlış kullanıldığı için halk arasında “jip” olarak yer edinmiştir. İlk olarak askeri amaçlarla üretilen cipler, günümüzde lüks ve konforun simgesi bir araç haline geldi. Bazen safari ve arazi aracı, bazen makam aracı olabilen cipler, “büyük otomobil” sınıfında anılır. SUV ve Crossover gibi büyük ve heybetli araçların çıkış noktası da ciplerdir. Artık prestij ve zenginliğin bir simgesi haline gelen cipler, geniş bir görüş açısı ve güvenli bir sürüş keyfi sunan araçlardır. Konfor ve rahatlık için sayısız özellik barındırırlar. “Jeep” dünya çapında cipleri temsil eden prestijli bir arazi aracı markasıdır. Ancak birçok otomotiv firması artık yeni nesil cipleri müşterilerine sunuyor. Cipler, çoğunlukla arazi koşullarına uygun olarak 4x4 yani dört tekerlekten çekiş özellikli üretilir. Segmentinde bulunan araç türlerinin en pahalısı cipler diyebiliriz. Tabi model ve markasına göre fiyatlar da farklılık gösterebilir. Yüksekliği, geniş iç hacmi ve gösterişli karoseri ile herkesin sahip olmak isteyeceği türden bir araç olan ciplere mercek tutalım!', N'/Content/images/blog4.jpg', N'1', N'2022-05-09 20:21:52.3500000');
INSERT INTO [Blogs] ([Id], [Title], [Description], [Tumbnail], [IsActive], [createTime]) VALUES (N'15', N'Deneme', N'Station Wagon (SW) ifadesinin Türkçe karşılığı “istasyon vagonu”, “istasyon kasası” şeklindedir. Tren istasyonlarında yük ve yolcu taşımak için kullanılan araçlardan ortaya çıkan bir araç türüdür. Aslında bir otomobil segmenti veya modelidir. Geniş ve uzun bagaj hacmi ile diğer otomobillerden ayrılan uzun araçlardır. Çatısı aracın arka ucuna kadar uzanır. Hatchbacklerin bagajı uzun, sedanların bagajı yüksek versiyonu da diyebiliriz. Genellikle 5 kapılı, yük taşıma kapasitesi yüksek otomobil türüdür. Arka koltukların arkasındaki geniş bagaj hacmi ile özellikle kalabalık aileler için ideal bir otomobildir. Birçok otomotiv firması, farklı model ve tasarımlarda station wagonlar üretiyor. Ancak ağırlığı ve yüksek yakıt tüketimi gibi faktörler sebebiyle pek tercih edilmeyen araçlardır. Daha doğrusu station wagonların müşterileri özeldir. Herkes station wagon kullanmak istemez; ancak bu modellerin tutkunları da başka araç kullanmaz. Amerika’da çok tercih edilen bir otomobildir. Bu sebeple “Amerika otomobili” olarak bilinir. Türkiye’de genellikle iş dünyasında rastlarız. Sanayilerde pratik bir yük taşıma aracı olarak yaygındır. Bazı iş kollarının vazgeçemediği bir tasarımdır. Kırsal kesimlerde daha sık tercih edilir. Türkler kısaca “steyşın” olarak adlandırır. Makalemizde station wagonların tarihini, diğer otomobillerden farklarını ve özelliklerini bulabilirsiniz.', N'/Content/images/me.jpeg', N'1', N'2022-05-21 01:28:08.0000000');
GO
SET IDENTITY_INSERT [Blogs] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for [HeadCars]
-- ----------------------------
DROP TABLE [HeadCars]
GO
CREATE TABLE [HeadCars] (
[Id] int NOT NULL IDENTITY(1,1) ,
[Title] nvarchar(50) NOT NULL ,
[Tumbnail] nvarchar(MAX) NOT NULL ,
[IsActive] bit NOT NULL 
)


GO

-- ----------------------------
-- Records of HeadCars
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [HeadCars] ON
GO
INSERT INTO [HeadCars] ([Id], [Title], [Tumbnail], [IsActive]) VALUES (N'1', N'CLASSIC CARS', N'/Content/images/car-section1.png', N'1');
GO
SET IDENTITY_INSERT [HeadCars] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for [ImageGalleries]
-- ----------------------------
DROP TABLE [ImageGalleries]
GO
CREATE TABLE [ImageGalleries] (
[Id] int NOT NULL IDENTITY(1,1) ,
[Tumbnail] nvarchar(250) NOT NULL ,
[IsActive] bit NOT NULL 
)


GO
DBCC CHECKIDENT(N'[ImageGalleries]', RESEED, 6)
GO

-- ----------------------------
-- Records of ImageGalleries
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [ImageGalleries] ON
GO
INSERT INTO [ImageGalleries] ([Id], [Tumbnail], [IsActive]) VALUES (N'1', N'/Content/images/gallery-car-1.jpg', N'1');
INSERT INTO [ImageGalleries] ([Id], [Tumbnail], [IsActive]) VALUES (N'2', N'/Content/images/gallery-car-2.jpg', N'1');
INSERT INTO [ImageGalleries] ([Id], [Tumbnail], [IsActive]) VALUES (N'3', N'/Content/images/gallery-car-3.jpg', N'1');
INSERT INTO [ImageGalleries] ([Id], [Tumbnail], [IsActive]) VALUES (N'4', N'/Content/images/gallery-car-4.jpg', N'1');
INSERT INTO [ImageGalleries] ([Id], [Tumbnail], [IsActive]) VALUES (N'5', N'/Content/images/gallery-car-5.jpg', N'1');
INSERT INTO [ImageGalleries] ([Id], [Tumbnail], [IsActive]) VALUES (N'6', N'/Content/images/gallery-car-6.jpg', N'1');
GO
SET IDENTITY_INSERT [ImageGalleries] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for [PopularCars]
-- ----------------------------
DROP TABLE [PopularCars]
GO
CREATE TABLE [PopularCars] (
[Id] int NOT NULL IDENTITY(1,1) ,
[Name] nvarchar(30) NOT NULL ,
[Price] money NOT NULL ,
[Tumbnail] nvarchar(250) NOT NULL ,
[IsActive] bit NOT NULL 
)


GO
DBCC CHECKIDENT(N'[PopularCars]', RESEED, 3)
GO

-- ----------------------------
-- Records of PopularCars
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [PopularCars] ON
GO
INSERT INTO [PopularCars] ([Id], [Name], [Price], [Tumbnail], [IsActive]) VALUES (N'1', N'CAR NAME', N'200.0000', N'/Content/images/car-1.jpg', N'1');
INSERT INTO [PopularCars] ([Id], [Name], [Price], [Tumbnail], [IsActive]) VALUES (N'2', N'CAR NAME', N'100.0000', N'/Content/images/car-2.jpg', N'1');
INSERT INTO [PopularCars] ([Id], [Name], [Price], [Tumbnail], [IsActive]) VALUES (N'3', N'CAR NAME', N'150.0000', N'/Content/images/car-3.jpg', N'1');
GO
SET IDENTITY_INSERT [PopularCars] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for [Users]
-- ----------------------------
DROP TABLE [Users]
GO
CREATE TABLE [Users] (
[Id] int NOT NULL IDENTITY(1,1) ,
[Name] nvarchar(100) NOT NULL ,
[LastName] nvarchar(100) NOT NULL ,
[Email] nvarchar(MAX) NOT NULL ,
[Parola] nvarchar(MAX) NOT NULL ,
[Tumbnail] nvarchar(300) NOT NULL ,
[createDate] datetime2(7) NOT NULL DEFAULT (getdate()) ,
[Role] int NOT NULL DEFAULT ((0)) 
)


GO
DBCC CHECKIDENT(N'[Users]', RESEED, 3)
GO

-- ----------------------------
-- Records of Users
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [Users] ON
GO
INSERT INTO [Users] ([Id], [Name], [LastName], [Email], [Parola], [Tumbnail], [createDate], [Role]) VALUES (N'1', N'Ahmet Burak', N'Karakaya', N'ahmet.karakaya99@erzurum.edu.tr', N'123456', N'~/Content/images/etulogo1.png', N'2022-05-09 20:21:52.4300000', N'1');
INSERT INTO [Users] ([Id], [Name], [LastName], [Email], [Parola], [Tumbnail], [createDate], [Role]) VALUES (N'2', N'Melih', N'Karakaya', N'melih.karakaya@example.com.tr', N'123456', N'~/Content/images/etulogo1.png', N'2022-05-09 20:21:52.4300000', N'1');
INSERT INTO [Users] ([Id], [Name], [LastName], [Email], [Parola], [Tumbnail], [createDate], [Role]) VALUES (N'3', N'Zeynep', N'Karakaya', N'zeynep.karakaya@example.com.tr', N'123456', N'~/Content/images/etulogo1.png', N'2022-05-09 20:21:52.4300000', N'1');
GO
SET IDENTITY_INSERT [Users] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for [VideoGalleries]
-- ----------------------------
DROP TABLE [VideoGalleries]
GO
CREATE TABLE [VideoGalleries] (
[Id] int NOT NULL IDENTITY(1,1) ,
[VideoUrl] nvarchar(250) NOT NULL ,
[IsActive] bit NOT NULL 
)


GO
DBCC CHECKIDENT(N'[VideoGalleries]', RESEED, 6)
GO

-- ----------------------------
-- Records of VideoGalleries
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [VideoGalleries] ON
GO
INSERT INTO [VideoGalleries] ([Id], [VideoUrl], [IsActive]) VALUES (N'1', N'/Content/images/car-video-1.mp4', N'1');
INSERT INTO [VideoGalleries] ([Id], [VideoUrl], [IsActive]) VALUES (N'2', N'/Content/images/car-video-2.mp4', N'1');
INSERT INTO [VideoGalleries] ([Id], [VideoUrl], [IsActive]) VALUES (N'3', N'/Content/images/car-video-3.mp4', N'1');
INSERT INTO [VideoGalleries] ([Id], [VideoUrl], [IsActive]) VALUES (N'4', N'/Content/images/car-video-4.mp4', N'1');
INSERT INTO [VideoGalleries] ([Id], [VideoUrl], [IsActive]) VALUES (N'5', N'/Content/images/car-video-5.mp4', N'1');
INSERT INTO [VideoGalleries] ([Id], [VideoUrl], [IsActive]) VALUES (N'6', N'/Content/images/car-video-6.mp4', N'1');
GO
SET IDENTITY_INSERT [VideoGalleries] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Indexes structure for table __EFMigrationsHistory
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [__EFMigrationsHistory]
-- ----------------------------
ALTER TABLE [__EFMigrationsHistory] ADD PRIMARY KEY ([MigrationId])
GO

-- ----------------------------
-- Indexes structure for table Blogs
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [Blogs]
-- ----------------------------
ALTER TABLE [Blogs] ADD PRIMARY KEY ([Id])
GO

-- ----------------------------
-- Indexes structure for table HeadCars
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [HeadCars]
-- ----------------------------
ALTER TABLE [HeadCars] ADD PRIMARY KEY ([Id])
GO

-- ----------------------------
-- Indexes structure for table ImageGalleries
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [ImageGalleries]
-- ----------------------------
ALTER TABLE [ImageGalleries] ADD PRIMARY KEY ([Id])
GO

-- ----------------------------
-- Indexes structure for table PopularCars
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [PopularCars]
-- ----------------------------
ALTER TABLE [PopularCars] ADD PRIMARY KEY ([Id])
GO

-- ----------------------------
-- Indexes structure for table Users
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [Users]
-- ----------------------------
ALTER TABLE [Users] ADD PRIMARY KEY ([Id])
GO

-- ----------------------------
-- Indexes structure for table VideoGalleries
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [VideoGalleries]
-- ----------------------------
ALTER TABLE [VideoGalleries] ADD PRIMARY KEY ([Id])
GO
