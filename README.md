# 🖥️ XML & JSON Data Processing Projects

[English](#english) | [Türkçe](#türkçe)

---

## English

### 🚀 Overview
A comprehensive C# solution containing multiple projects focused on data handling, serialization, and database integration. This repository was created to demonstrate different methods of processing XML and JSON data in both Windows Forms and Console environments.

### ✨ Features
- **HaberSiteleriveRSS:** A real-time news aggregator that fetches live data from Hürriyet RSS using `XmlDocument`.
- **JSON_Project:** A modern console application demonstrating high-performance object serialization with `System.Text.Json`.
- **TCMBKurCek:** A financial tool designed to fetch and parse daily exchange rates from the Central Bank of the Republic of Türkiye.
- **XMLvsADO.NET:** A database-driven application that connects to SQL Server LocalDB and exports relational data into structured XML files. **NOTE:** This project requires the Northwind sample database. If you don't have it, you can download the installation script from Microsoft's official sample repository and run it on your LocalDB instance.
- **XML Sample - READXML:** A foundational project focused on reading and displaying XML data using `DataSet` and `DataGridView`.
- **XML_Sample_XMLDocument:** An advanced XML manipulation project using node-based navigation and `XmlNodeList`.

### 🛠️ Installation & Usage
1. Clone the repository:
   ```git clone https://github.com/ardabicerel/XML_JSON_Projects.git```
3. Open the solution in **Visual Studio 2022**:
   Double-click ```XML_JSON_Projects.sln```.
4. Database Setup:
   For ```XMLvsADO.NET```, ensure SQL Server LocalDB is running and the Northwind database is attached.
5. Run:
   Right-click the project you want to test and select Set as Startup Project, then press F5.
  
---

## Türkçe

### 🚀 Genel Bakış
Veri yönetimi, serileştirme ve veritabanı entegrasyonuna odaklanan birden fazla projeyi içeren kapsamlı bir C# çözümüdür. Bu depo, Windows Forms ve Konsol ortamlarında XML ve JSON verilerini işlemenin farklı yöntemlerini göstermek amacıyla oluşturulmuştur.

### ✨ Özellikler
- **HaberSiteleriveRSS:** XmlDocument kullanarak Hürriyet RSS kaynağından canlı haber verilerini çeken bir haber toplayıcıdır.
- **JSON_Project:** System.Text.Json ile yüksek performanslı nesne serileştirmesini gösteren modern bir konsol uygulamasıdır.
- **TCMBKurCek:** Türkiye Cumhuriyeti Merkez Bankası'ndan günlük döviz kurlarını çeken ve ayrıştıran finansal bir araçtır.
- **XMLvsADO.NET:** SQL Server LocalDB'ye bağlanan ve ilişkisel verileri yapılandırılmış XML dosyalarına aktaran veritabanı tabanlı bir uygulamadır. **NOT:** Bu projenin çalışması için Northwind örnek veritabanı gereklidir. Eğer bilgisayarınızda yüklü değilse, kurulum betiğini (script) Microsoft'un resmi örnek deposundan indirebilir ve LocalDB örneğinizde (instance) çalıştırabilirsiniz.
- **XML Sample - READXML:** DataSet ve DataGridView kullanarak XML verilerini okumaya ve görüntülemeye odaklanan temel bir projedir.
- **XML_Sample_XMLDocument:** Düğüm tabanlı navigasyon ve XmlNodeList kullanan gelişmiş bir XML yönetim projesidir.

### 🛠️ Kurulum ve Kullanım

1. Depoyu klonlayın:
   ```git clone https://github.com/ardabicerel/XML_JSON_Projects.git```
2. Çözümü **Visual Studio 2022** ile açın:
   ```XML_JSON_Projects.sln``` dosyasına çift tıklayın.
4. Veritabanı Kurulumu:
   ```XMLvsADO.NET``` projesi için SQL Server LocalDB'nin çalıştığından ve Northwind veritabanının bağlı olduğundan emin olun.
5. Çalıştırma
   Test etmek istediğiniz projeye sağ tıklayın, **Başlangıç Projesi Olarak Ayarla**'yı seçin ve F5'e basın.
  
### 📋 Technical Details / Teknik Detaylar
- **Language/Dil:** C# (.NET Framework & .NET 6+)
- **Technologies/Teknolojiler:** ADO.NET, SQL Server LocalDB, XML, JSON (System.Text.Json), RSS
- **Library/Kütüphane:** System.Xml, System.Text.Json, System.Data.SqlClient
