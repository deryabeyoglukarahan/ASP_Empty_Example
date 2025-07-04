# ASP.NET Core MVC 

Bu proje, **ASP.NET Core Empty Template** kullanılarak oluşturulmuş ve MVC (Model-View-Controller) tasarım desenine uygun olarak yapılandırılmıştır.

## 🔧 Yapılandırılan Klasörler

- Controllers/ → Controller sınıflarının yer aldığı klasör
- Models/ → Veri modellerinin yer aldığı klasör
- Views/ → Razor View (.cshtml) dosyalarının yer aldığı klasör
- wwwroot/ → Statik dosyaların (CSS, JS, görseller) bulunduğu klasör
- Program.cs → Uygulamanın başlatıldığı ve yapılandırmaların yapıldığı dosya

## ⚙️ Program.cs İçerisinde Yapılan Yapılandırmalar

- **MVC Servislerinin Eklenmesi:** `builder.Services.AddControllersWithViews();`  
  → MVC yapısının kullanılabilmesi için gerekli servisler eklendi.

- **Statik Dosyaların Aktifleştirilmesi:** `app.UseStaticFiles();`  
  → wwwroot klasörü altındaki dosyaların tarayıcıdan erişilebilir olması sağlandı.

- **Routing Konfigürasyonu:** `app.UseRouting();` ve `app.MapControllerRoute(...);`  
  → Tarayıcıdan gelen isteklerin doğru controller ve action metoduna yönlendirilmesi sağlandı.

- **Varsayılan Routing:**  
  ```csharp
  pattern: "{controller=Home}/{action=Index}/{id?}"
