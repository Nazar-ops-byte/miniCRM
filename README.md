---

# 🏋️‍♀️ CRM Yönetim Sistemi (WinForms)

Bu proje, bir **dalgıç kursu salonu / hizmet odaklı işletme** için geliştirilmiş;
**müşteri yönetimi**, **personel yönetimi**, **hizmet tanımlama**, **talep & satış takibi** ve **raporlama** süreçlerini dijital ortamda yönetmeyi amaçlayan bir **Windows Forms masaüstü uygulamasıdır**.

Proje, **katmanlı mimari (N-Tier Architecture)** yapısı sayesinde sürdürülebilir, geliştirilebilir ve temiz bir kod yapısı sunar.

---

## 📌 Proje Özellikleri

### 🔐 Kullanıcı Girişi ve Yetkilendirme

* **Rol bazlı giriş sistemi**

  * Admin
  * Call Center
  * Support
* **Yetkilendirme:** Kullanıcı rolüne göre erişilebilir ekranlar
* **Güvenlik:** Kullanıcı adı & şifre kontrolü

---

### 👥 Müşteri Yönetimi

* Müşteri ekleme, güncelleme ve silme
* İletişim bilgileri ve üyelik türü takibi
* Müşteri–hizmet ilişkilerinin yönetimi
* DataGridView üzerinden listeleme

---

### 🧑‍💼 Personel Yönetimi

* Personel ekleme, güncelleme ve silme
* Rol ve uzmanlık alanı tanımlama
* Talep ve işlemlere personel atama

---

### 🛎️ Hizmet Yönetimi

* Hizmet ekleme, güncelleme ve silme
* Hizmet açıklaması ve fiyat bilgileri
* Satış ve taleplerle entegre yapı

---

### 📄 Talep & Satış İşlemleri

* Müşteri ve hizmet seçimi
* Talep türü ve durum takibi
* Personel atama
* Satış ve hizmet süreçlerinin kayıt altına alınması
* Tarih bazlı kayıt

---

### 📊 Raporlama ve Dashboard

* Tarih aralığına göre raporlama
* Hizmet bazlı ve durum bazlı filtreleme
* DataGridView ile rapor listeleme
* İşletme performansını analiz etmeye yönelik ekranlar

---

## 📐 Mimari Yapı

Proje **katmanlı mimari** kullanılarak geliştirilmiştir:

* **UI (User Interface)**
  Windows Forms arayüzleri

* **BLL (Business Logic Layer)**
  İş kuralları ve kontroller

* **DAL (Data Access Layer)**
  MySQL veritabanı işlemleri

* **Domain / Entities**
  Veri modelleri (Customer, Service, Staff, Request vb.)

---

## 📂 Proje Yapısı

```text
CRMProjesi
│
├── CRMProjesi.UI        → Windows Forms arayüzleri
├── CRMProjesi.BLL       → İş mantığı
├── CRMProjesi.DAL       → Veritabanı işlemleri
├── CRMProjesi.Domain   → Veri modelleri
│
├── App.config           → MySQL bağlantı ayarları
├── Program.cs           → Uygulama başlangıç noktası
└── CRMProjesi.sln
```

---

## 🛠️ Kullanılan Teknolojiler

* **Programlama Dili:** C# (.NET Framework)
* **Arayüz:** Windows Forms
* **Veritabanı:** MySQL (phpMyAdmin)
* **Mimari:** Katmanlı Mimari (N-Tier)
* **Veri İşleme:** LINQ
* **Versiyon Kontrol:** Git & GitHub

---

## 🚀 Kurulum ve Çalıştırma

### 1️⃣ Projeyi Klonlayın

```bash
git clone https://github.com/Nazar-ops-byte/miniCRM.git
```

### 2️⃣ Visual Studio ile Açın

* `CRMProjesi.sln` dosyasını açın

### 3️⃣ Veritabanı Ayarları

* `App.config` içindeki MySQL bağlantı bilgilerini düzenleyin

### 4️⃣ Veritabanı Tabloları

MySQL üzerinde aşağıdaki tabloların oluşturulması gerekmektedir:

* kullanicilar
* musteriler
* personeller
* hizmetler
* talepler
* satislar

### 5️⃣ Çalıştırın

* Visual Studio üzerinden **F5** ile projeyi başlatın

---

## 🎯 Projenin Amaçları

✅ Müşteri ve hizmet süreçlerini dijitalleştirmek
✅ İşletme içi iş akışını düzenlemek
✅ Manuel hataları azaltmak
✅ Gerçek hayata uygun kurumsal bir CRM sistemi geliştirmek
✅ Katmanlı mimariyi uygulamalı olarak öğrenmek

---

## 📌 Geliştirilebilecek Özellikler

* 📄 PDF / Excel rapor çıktısı
* 🔐 Şifrelerin hashlenerek saklanması (SHA-256)
* 📊 Grafik tabanlı dashboard
* 🌐 Web veya mobil versiyon
* 🔔 Otomatik bildirim sistemi

---

## 👤 Geliştirici

**Ad Soyad:** Nazar Baştuğ

**Üniversite:** Uludağ Üniversitesi
## 🎥 Video

https://youtu.be/yRRQoHxY9vU?si=aN-a6KYjShcB6N6H

## 📌 Not
Bu proje eğitim ve akademik amaçlarla geliştirilmiştir.
**Bölüm:** Yönetim Bilişim Sistemleri
**GitHub:** [https://github.com/…](https://github.com/…)
