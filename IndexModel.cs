using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OzmetWebSite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        // Opsiyonel: Ýleride dinamik data için
        public string CompanyName { get; set; } = "ÖZMET Ýnþaat";
        public int ExperienceYears { get; set; } = 50;
        public int CompletedProjects { get; set; } = 1000;
        public int HappyClients { get; set; } = 2000;
        public int Awards { get; set; } = 15;

        public void OnGet()
        {
            // Þu an için boþ, ilerleye database'den data çekebilirsiniz
        }
    }
}

