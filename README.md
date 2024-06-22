# Veri Tabanlı Parti Seçim Grafik ve İstatistik Uygulaması

Bu proje, SQL veritabanı kullanarak ilçe bazında parti oylarını girdiğiniz ve sonuçları grafiksel olarak görüntülediğiniz bir Windows Forms uygulamasıdır.

## Kullanılan Teknolojiler

- C#
- .NET Framework
- Windows Forms
- SQL Server

## Kod Açıklamaları

### FrmOyGiris

`FrmOyGiris` formu, parti oylarının girildiği formdur.

#### Alanlar ve Özellikler

- `SqlConnection conn`: Bu alan, SQL Server veritabanı bağlantısı için kullanılır. Bağlantı stringi, veritabanının konumunu ve kimlik doğrulama bilgilerini içerir.

#### Olaylar ve Yöntemler

- `FrmOyGiris()`: Formun yapıcı metodudur. Form bileşenlerini başlatır.
- `btnOyGirisi_Click`: Bu olay, "Oy Girişi" butonuna tıklanıldığında tetiklenir. 
  - Veritabanı bağlantısını açar.
  - Kullanıcıdan alınan ilçe adı ve parti oylarını SQL komutu ile veritabanına ekler.
  - Komut tamamlandıktan sonra veritabanı bağlantısını kapatır ve bir mesaj kutusu ile oy girişinin başarılı olduğunu kullanıcıya bildirir.
  - SQL komutları ve parametreler:
    ```sql
    insert into TBLILCE (ILCEAD, APARTI, BPARTI, CPARTI, DPARTI, EPARTI) 
    values (@p1, @p2, @p3, @p4, @p5, @p6)
    ```
    Parametreler:
    - `@p1`: İlçe adı (`txtIlceAd.Text`)
    - `@p2`: A Parti oy sayısı (`txtAP.Text`)
    - `@p3`: B Parti oy sayısı (`txtBP.Text`)
    - `@p4`: C Parti oy sayısı (`txtCP.Text`)
    - `@p5`: D Parti oy sayısı (`txtDP.Text`)
    - `@p6`: E Parti oy sayısı (`txtEP.Text`)
- `btnGrafik_Click`: Bu olay, "Grafikler" butonuna tıklanıldığında tetiklenir.
  - `FrmGrafikler` formunu oluşturur ve gösterir.

### FrmGrafikler

`FrmGrafikler` formu, girilen oyların grafiksel gösterimini sağlar.

#### Alanlar ve Özellikler

- `SqlConnection conn`: Bu alan, SQL Server veritabanı bağlantısı için kullanılır.

#### Olaylar ve Yöntemler

- `FrmGrafikler()`: Formun yapıcı metodudur. Form bileşenlerini başlatır.
- `FrmGrafikler_Load`: Bu olay, form yüklendiğinde tetiklenir.
  - Veritabanı bağlantısını açar ve ilçe adlarını combobox'a çeker.
  - Veritabanı bağlantısını açar ve toplam oyları grafiklere yükler.
  - SQL komutları ve işlemler:
    ```sql
    select ILCEAD from TBLILCE
    ```
    İlçe adlarını combobox'a ekler:
    ```sql
    select SUM(APARTI), SUM(BPARTI), SUM(CPARTI), SUM(DPARTI), SUM(EPARTI) 
    from TBLILCE
    ```
    Toplam oyları grafiklere ekler.
- `comboBox1_SelectedIndexChanged`: Bu olay, combobox'taki seçilen ilçe değiştiğinde tetiklenir.
  - Veritabanı bağlantısını açar ve seçilen ilçenin oylarını progress bar'larda ve label'larda gösterir.
  - SQL komutu ve işlemler:
    ```sql
    select * from TBLILCE where ILCEAD=@p1
    ```
    Parametreler:
    - `@p1`: Seçilen ilçe adı (`comboBox1.Text`)
  - İlgili verileri progress bar'lara ve label'lara aktarır.

## Ekran Görüntüleri

### FrmOyGiris Sayfası Örnek Ekran Görüntüsü
![FrmOyGiris](https://github.com/huseynaktas/Veri_Tabanli_Parti_Secim_Grafik_Istatistik/assets/114494075/77fd135d-6a66-4a45-bac3-5a0074619640)

### FrmGrafikler Sayfası Örnek Ekran Görüntüsü
![FrmGrafikler](https://github.com/huseynaktas/Veri_Tabanli_Parti_Secim_Grafik_Istatistik/assets/114494075/3dcb381c-8b68-4200-a3e0-ed891ab8cd43)

### Veritabanı Diyagramı Ekran Görüntüsü
![Veritabanı  2](https://github.com/huseynaktas/Veri_Tabanli_Parti_Secim_Grafik_Istatistik/assets/114494075/58640b70-b6ca-4dbe-a25b-9e30e975d983)

