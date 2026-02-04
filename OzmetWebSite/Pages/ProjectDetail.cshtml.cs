using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OzmetWebSite.Pages
{
    public class ProjectDetailModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string Id { get; set; } = string.Empty;

        public string ProjectTitle { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string ShortDescription { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string DetailedDescription { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string CompletionDate { get; set; } = string.Empty;
        public string Area { get; set; } = string.Empty;
        public string MainImage { get; set; } = string.Empty;
        public List<string> GalleryImages { get; set; } = new();
        public Dictionary<string, string> TechnicalSpecs { get; set; } = new();
        public List<ProjectPhase> ProjectPhases { get; set; } = new();
        public string Client { get; set; } = string.Empty;
        public string ProjectType { get; set; } = string.Empty;
        public string StartDate { get; set; } = string.Empty;
        public string ProjectValue { get; set; } = string.Empty;

        public IActionResult OnGet()
        {
            LoadProjectData(Id);

            if (string.IsNullOrEmpty(ProjectTitle))
            {
                return NotFound();
            }

            return Page();
        }

        private void LoadProjectData(string projectId)
        {
            switch (projectId?.ToLower())
            {
                case "modern-villa":
                    LoadModernVillaData();
                    break;
                case "is-merkezi":
                    LoadBusinessCenterData();
                    break;
                case "rezidans":
                    LoadResidenceData();
                    break;
                default:
                    // Project not found
                    break;
            }
        }

        private void LoadModernVillaData()
        {
            ProjectTitle = "Modern Villa Projesi";
            Category = "Konut Ýnþaatý";
            ShortDescription = "Beykoz'da konumlu lüks modern villa projesi";
            Location = "Beykoz, Ýstanbul";
            CompletionDate = "Mayýs 2024";
            Area = "450 m²";
            MainImage = "https://images.unsplash.com/photo-1600596542815-ffad4c1539a9?ixlib=rb-4.0.3&auto=format&fit=crop&w=1200&q=80";

            Description = "Beykoz'un doðal güzelliklerini modern mimari ile buluþturan bu villa projesi, sürdürülebilir tasarým ilkeleriyle hayata geçirilmiþtir.";
            DetailedDescription = "Proje, 450 metrekarelik kapalý alan üzerinde 4 yatak odasý, 3 banyo, açýk mutfak konsepti ve geniþ oturma alanlarýndan oluþmaktadýr. Akýllý ev sistemleri, enerji verimli çözümler ve doðal malzemeler kullanýlarak tamamlanmýþtýr. Bahçe peyzajý ve yüzme havuzu ile birlikte lüks yaþam alaný oluþturulmuþtur.";

            GalleryImages = new List<string>
            {
                "https://images.unsplash.com/photo-1600596542815-ffad4c1539a9?ixlib=rb-4.0.3&auto=format&fit=crop&w=600&q=80",
                "https://images.unsplash.com/photo-1613977257363-707ba9348227?ixlib=rb-4.0.3&auto=format&fit=crop&w=600&q=80",
                "https://images.unsplash.com/photo-1560472354-b33ff0c44a43?ixlib=rb-4.0.3&auto=format&fit=crop&w=600&q=80",
                "https://images.unsplash.com/photo-1581094794329-c8112a89af12?ixlib=rb-4.0.3&auto=format&fit=crop&w=600&q=80",
                "https://images.unsplash.com/photo-1600607687939-ce8a6c25118c?ixlib=rb-4.0.3&auto=format&fit=crop&w=600&q=80",
                "https://images.unsplash.com/photo-1560518883-ce09059eeffa?ixlib=rb-4.0.3&auto=format&fit=crop&w=600&q=80"
            };

            TechnicalSpecs = new Dictionary<string, string>
            {
                { "Yapý Alaný", "450 m²" },
                { "Arsa Alaný", "800 m²" },
                { "Kat Sayýsý", "2 Kat + Bodrum" },
                { "Oda Sayýsý", "4+1" },
                { "Garaj", "2 Araçlýk Kapalý Garaj" },
                { "Bahçe", "Peyzajlý Bahçe ve Havuz" },
                { "Enerji Sýnýfý", "A+ Enerji Sýnýfý" },
                { "Isýtma Sistemi", "Yerden Isýtma + Klima" }
            };

            ProjectPhases = new List<ProjectPhase>
            {
                new ProjectPhase { Title = "Tasarým ve Planlama", Duration = "2 Ay", Description = "Mimari tasarým, statik hesaplamalar ve ruhsat iþlemleri" },
                new ProjectPhase { Title = "Temel ve Kaba Ýnþaat", Duration = "4 Ay", Description = "Kazý, temel atma ve kaba inþaat çalýþmalarý" },
                new ProjectPhase { Title = "Ýnce Ýnþaat", Duration = "3 Ay", Description = "Elektrik, tesisat, sýva ve boyama iþleri" },
                new ProjectPhase { Title = "Son Rötuþlar", Duration = "1 Ay", Description = "Peyzaj düzenlemesi ve teslim öncesi kontroller" }
            };

            Client = "Özel Müþteri";
            ProjectType = "Lüks Villa";
            StartDate = "Ocak 2024";
            ProjectValue = "2.500.000 TL";
        }

        private void LoadBusinessCenterData()
        {
            ProjectTitle = "Ýþ Merkezi Projesi";
            Category = "Ticari Ýnþaat";
            ShortDescription = "Levent'te modern ofis kompleksi";
            Location = "Levent, Ýstanbul";
            CompletionDate = "Eylül 2024";
            Area = "2.800 m²";
            MainImage = "https://images.unsplash.com/photo-1545324418-cc1a3fa10c00?ixlib=rb-4.0.3&auto=format&fit=crop&w=1200&q=80";

            Description = "Levent iþ merkezi bölgesinde konumlu, modern iþ yaþamýnýn tüm gereksinimlerini karþýlayan çok fonksiyonlu ofis kompleksi.";
            DetailedDescription = "8 katlý binamýz toplam 2.800 metrekare ofis alaný sunmaktadýr. Akýllý bina teknolojileri, enerji verimli sistemler ve LEED sertifikasý standartlarýnda inþa edilmiþtir. 24/7 güvenlik, kapalý otopark ve konferans salonlarý ile tam donanýmlý iþ merkezi.";

            GalleryImages = new List<string>
            {
                "https://images.unsplash.com/photo-1545324418-cc1a3fa10c00?ixlib=rb-4.0.3&auto=format&fit=crop&w=600&q=80",
                "https://images.unsplash.com/photo-1486406146926-c627a92ad1ab?ixlib=rb-4.0.3&auto=format&fit=crop&w=600&q=80",
                "https://images.unsplash.com/photo-1582407947304-fd86f028f716?ixlib=rb-4.0.3&auto=format&fit=crop&w=600&q=80",
                "https://images.unsplash.com/photo-1541888946425-d81bb19240f5?ixlib=rb-4.0.3&auto=format&fit=crop&w=600&q=80",
                "https://images.unsplash.com/photo-1503387762-592deb58ef4e?ixlib=rb-4.0.3&auto=format&fit=crop&w=600&q=80",
                "https://images.unsplash.com/photo-1504307651254-35680f356dfd?ixlib=rb-4.0.3&auto=format&fit=crop&w=600&q=80"
            };

            TechnicalSpecs = new Dictionary<string, string>
            {
                { "Toplam Alan", "2.800 m²" },
                { "Kat Sayýsý", "8 Kat + 2 Bodrum" },
                { "Ofis Sayýsý", "24 Baðýmsýz Ofis" },
                { "Otopark", "50 Araçlýk Kapalý Otopark" },
                { "Asansör", "2 Adet Yolcu + 1 Yük Asansörü" },
                { "Güvenlik", "7/24 Güvenlik Sistemi" },
                { "Sertifika", "LEED Gold Sertifikalý" },
                { "Ýklim", "Merkezi VRV Sistem" }
            };

            ProjectPhases = new List<ProjectPhase>
            {
                new ProjectPhase { Title = "Proje ve Ruhsat", Duration = "3 Ay", Description = "Mimari proje hazýrlýðý ve belediye ruhsat süreçleri" },
                new ProjectPhase { Title = "Kazý ve Temel", Duration = "2 Ay", Description = "Derin kazý ve temel inþaat çalýþmalarý" },
                new ProjectPhase { Title = "Kaba Ýnþaat", Duration = "8 Ay", Description = "Betonarme iskelet ve duvar örgü çalýþmalarý" },
                new ProjectPhase { Title = "Ýnce Ýnþaat ve Tamamlama", Duration = "4 Ay", Description = "Mekanik tesisatlar, cephe ve iç mekan iþleri" }
            };

            Client = "Levent Ýnþaat A.Þ.";
            ProjectType = "Ofis Kompleksi";
            StartDate = "Ocak 2024";
            ProjectValue = "15.000.000 TL";
        }

        private void LoadResidenceData()
        {
            ProjectTitle = "Rezidans Projesi";
            Category = "Konut Ýnþaatý";
            ShortDescription = "Kadýköy'de lüks konut kompleksi";
            Location = "Kadýköy, Ýstanbul";
            CompletionDate = "Aralýk 2024";
            Area = "5.200 m²";
            MainImage = "https://images.unsplash.com/photo-1600607687939-ce8a6c25118c?ixlib=rb-4.0.3&auto=format&fit=crop&w=1200&q=80";

            Description = "Kadýköy'ün merkezinde konumlu, deniz manzaralý lüks rezidans kompleksi. Yüksek yaþam kalitesi sunan modern apartmanlar.";
            DetailedDescription = "12 katlý rezidans kompleksimiz 48 daireden oluþmaktadýr. Her dairede geniþ balkonlar, kaliteli malzemeler ve akýllý ev sistemleri bulunmaktadýr. Sosyal tesisler arasýnda fitness merkezi, çocuk oyun alanlarý ve açýk havuz yer almaktadýr.";

            GalleryImages = new List<string>
            {
                "https://images.unsplash.com/photo-1600607687939-ce8a6c25118c?ixlib=rb-4.0.3&auto=format&fit=crop&w=600&q=80",
                "https://images.unsplash.com/photo-1600596542815-ffad4c1539a9?ixlib=rb-4.0.3&auto=format&fit=crop&w=600&q=80",
                "https://images.unsplash.com/photo-1560518883-ce09059eeffa?ixlib=rb-4.0.3&auto=format&fit=crop&w=600&q=80",
                "https://images.unsplash.com/photo-1613977257363-707ba9348227?ixlib=rb-4.0.3&auto=format&fit=crop&w=600&q=80",
                "https://images.unsplash.com/photo-1560472354-b33ff0c44a43?ixlib=rb-4.0.3&auto=format&fit=crop&w=600&q=80",
                "https://images.unsplash.com/photo-1581094794329-c8112a89af12?ixlib=rb-4.0.3&auto=format&fit=crop&w=600&q=80"
            };

            TechnicalSpecs = new Dictionary<string, string>
            {
                { "Toplam Alan", "5.200 m²" },
                { "Kat Sayýsý", "12 Kat + 2 Bodrum" },
                { "Daire Sayýsý", "48 Daire" },
                { "Daire Tipleri", "2+1, 3+1, 4+1" },
                { "Otopark", "60 Araçlýk Kapalý Otopark" },
                { "Sosyal Tesis", "Havuz, Fitness, Çocuk Parký" },
                { "Güvenlik", "7/24 Güvenlik ve Kamera Sistemi" },
                { "Manzara", "Deniz ve Þehir Manzarasý" }
            };

            ProjectPhases = new List<ProjectPhase>
            {
                new ProjectPhase { Title = "Tasarým ve Ýzinler", Duration = "4 Ay", Description = "Mimari tasarým, yapý ruhsatý ve çevre düzenlemesi planlarý" },
                new ProjectPhase { Title = "Temel Çalýþmalarý", Duration = "3 Ay", Description = "Kazý, perde duvar ve temel betonaj çalýþmalarý" },
                new ProjectPhase { Title = "Üst Yapý Ýnþaatý", Duration = "12 Ay", Description = "Betonarme iskelet, duvarlar ve çatý inþaatý" },
                new ProjectPhase { Title = "Ýç ve Dýþ Cephe", Duration = "6 Ay", Description = "Ýç mekan iþleri, cephe kaplama ve peyzaj düzenlemesi" }
            };

            Client = "Kadýköy Yapý Kooperatifi";
            ProjectType = "Rezidans Kompleksi";
            StartDate = "Ocak 2023";
            ProjectValue = "25.000.000 TL";
        }
    }

    public class ProjectPhase
    {
        public string Title { get; set; } = string.Empty;
        public string Duration { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
