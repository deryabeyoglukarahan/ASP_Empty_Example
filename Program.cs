var builder = WebApplication.CreateBuilder(args);

// MVC servislerini ekle
builder.Services.AddControllersWithViews();

var app = builder.Build();

// wwwroot klasöründeki statik dosyalara izin ver
app.UseStaticFiles();

// Routing işlemlerini başlat
app.UseRouting();

// Varsayılan route yapılandırması
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


// -------------------------- KAVRAM AÇIKLAMALARI --------------------------

// Controller:
// Kullanıcıdan gelen isteği karşılayan sınıftır. İş mantığını çalıştırır, model ile view arasında köprü görevi görür.

// Action:
// Controller içindeki metotlardır. İsteklere karşılık gelen işlemleri yapar ve genellikle bir View döndürür.

// Model:
// Uygulamadaki verileri ve iş kurallarını temsil eden sınıftır. Veritabanı ile uygulama arasındaki veri yapısını tanımlar.

// View:
// Kullanıcıya gösterilecek olan HTML içerikli sayfadır. Razor (cshtml) yapısıyla yazılır ve dinamik içerik gösterebilir.

// Razor:
// HTML ile C# kodlarının birlikte kullanılmasına olanak sağlayan sözdizimidir (@ işareti ile başlar).

// RazorView:
// Razor motoru tarafından işlenen .cshtml uzantılı sayfalardır. Dinamik HTML üretimini sağlar.

// wwwroot:
// Statik dosyaların (CSS, JS, görsel vb.) tutulduğu klasördür. Tarayıcı doğrudan bu dosyalara erişebilir.


// -------------------------- METOT AÇIKLAMALARI --------------------------

// builder.Build():
// Tüm yapılandırma ve servis ekleme işlemlerinden sonra uygulama nesnesini oluşturur. Uygulamanın çalışma altyapısını hazır hale getirir.

// app.Run():
// Uygulamayı çalıştırır. Web sunucusunu başlatır ve gelen HTTP isteklerini dinlemeye başlar.
