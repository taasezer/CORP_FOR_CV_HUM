# CORP Abonelik Yönetimi Sistemi

Basit bir abonelik sistemi .NET Core öğrenmek içindi.

##  Özellikler

- **Clean Architecture** mimarisi
- **Entity Framework Core** ile veritabanı işlemleri
- **Dependency Injection** desteği
- **RESTful API**
- **Swagger** dokümantasyonu
- **SQL Server** veritabanı desteği

## Proje Yapısı

```
CORP_REAL/
├── CORP_Core.cs           # Domain Layer (Entities & Interfaces)
├── CORP_Application.cs    # Application Layer (Services)
├── CORP_Infrastructure.cs # Infrastructure Layer (Repository & DbContext)
├── CORP_Presentation.cs   # Presentation Layer (Controllers)
└── Program.cs            # Startup Configuration
```

## Kurulum

### Gereksinimler

- .NET 6.0 veya üzeri
- SQL Server (LocalDB destekli)
- Visual Studio 2022 veya JetBrains Rider

### Adımlar

1. **Projeyi klonlayın:**
   ```bash
   git clone https://github.com/[kullanici-adi]/CORP_REAL.git
   cd CORP_REAL
   ```

2. **NuGet paketlerini yükleyin:**
   ```bash
   dotnet restore
   ```

3. **Gerekli paketleri ekleyin:**
   ```bash
   dotnet add package Microsoft.EntityFrameworkCore.SqlServer
   dotnet add package Microsoft.EntityFrameworkCore.Tools
   dotnet add package Swashbuckle.AspNetCore
   ```

4. **Veritabanı bağlantısını yapılandırın:**
   - `Program.cs` dosyasındaki connection string'i kendi ortamınıza göre düzenleyin

5. **Projeyi çalıştırın:**
   ```bash
   dotnet run
   ```

## API

### Abonelikler

| Method | Endpoint | Açıklama |
|--------|----------|----------|
| GET | `/api/abonelikler` | Tüm abonelikleri listele |
| GET | `/api/abonelikler/{id}` | ID ile abonelik getir |
| POST | `/api/abonelikler` | Yeni abonelik oluştur |

### Örnek Kullanım

**Tüm abonelikleri getir:**
```http
GET /api/abonelikler
```

**Yeni abonelik oluştur:**
```http
POST /api/abonelikler
Content-Type: application/json

{
  "ad": "Premium Abonelik",
  "fiyat": 99.99,
  "aciklama": "Tüm özelliklere erişim"
}
```

## Mimari

- **Domain Layer**: İş mantığı ve entity'ler
- **Application Layer**: Servis sınıfları ve iş kuralları
- **Infrastructure Layer**: Veritabanı erişimi ve dış kaynak entegrasyonları
- **Presentation Layer**: API controllerları


## Veritabanı

Proje SQL Server LocalDB kullanmaktadır. İlk çalıştırmada veritabanı otomatik olarak oluşturulur.

**Veritabanı Adı:** `CORP_DB`


## Geliştirme ve Katkı
Proje açık kaynak olarak geliştirilmekte olup, katkılarınızı memnuniyetle karşılarım.
Lütfen hata bildirmek veya özellik talep etmek için issue açınız. Pull request göndermekten çekinmeyiniz.

## İletişim
Herhangi bir soru veya destek talebi için aşağıdaki iletişim adresleri kullanılabilir:

## E-posta: [taha.sezer@istun.edu.tr]
