# Geometrik Cisimlerin Çarpışma Denetimi Projesi

Bu proje, çeşitli 2D ve 3D cisimler arasındaki çarpışma denetimlerini gerçekleştirmek amacıyla geliştirilmiştir. Statik metotlar ve bir grafik arayüzü kullanılarak farklı cisimlerin çarpışma durumları belirlenir ve görselleştirilir.

## İçerik

- **Statik Sınıf:** Çarpışma denetim metotlarını içeren statik sınıf.
  - Nokta, Dörtgen çarpışma denetimi
  - Nokta, Çember çarpışma denetimi
  - Dikdörtgen, Dikdörtgen çarpışma denetimi
  - Dikdörtgen, Çember çarpışma denetimi
  - Çember, Çember çarpışma denetimi
  - Nokta, Küre çarpışma denetimi
  - Nokta, Dikdörtgen Prizma çarpışma denetimi
  - Nokta, Silindir çarpışma denetimi
  - Silindir, Silindir çarpışma denetimi
  - Küre, Küre çarpışma denetimi
  - Küre, Silindir çarpışma denetimi
  - Yüzey, Küre çarpışma denetimi
  - Yüzey, Dikdörtgen Prizma çarpışma denetimi
  - Yüzey, Silindir çarpışma denetimi
  - Küre, Dikdörtgen Prizma çarpışma denetimi
  - Dikdörtgen Prizma, Dikdörtgen Prizma çarpışma denetimi


### Grafik Arayüzü
Projede bir Windows Form uygulaması kullanılarak grafik arayüzü oluşturulmuştur:
- **Nesne Ekleme:** List veya Dictionary yapıları kullanılarak 8 farklı cisim eklenir.
- **Cisim Çizimi ve Çarpışma Denetimi:** Cisimler ekranda çizilir ve dinamik olarak hareket ettirilir. Çarpışma denetimleri sürekli olarak yapılır.

## Proje Dosyaları

Aşağıdaki dosyalar proje ile birlikte sağlanmalıdır:
- `cisimcarpismadenetim.csproj` - Proje dosyası
- `Form1.cs` - Grafik arayüzü kodu
- `Form1.Designer.cs` - Grafik arayüzü tasarımı
- `Form1.resx` - Grafik arayüzü kaynak dosyaları
- `Program.cs` - Uygulamanın başlangıç noktası
- `README.md` 
