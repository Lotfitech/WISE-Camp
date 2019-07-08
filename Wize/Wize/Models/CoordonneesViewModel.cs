using Newtonsoft.Json;

namespace Wize.Models
{
    public class CoordonneesViewModel
    {
        // TEXT (0 , 50)
        [JsonProperty(PropertyName = "civilite")]
        public string civilite { get; set; } 
        // TEXT (0 , 50)
        [JsonProperty(PropertyName = "nom")]
        public string nom { get; set; } 
        // TEXT (0 , 50)
        [JsonProperty(PropertyName = "prenom")]
        public string prenom { get; set; } 
        // TEXT (0 , 50)
        [JsonProperty(PropertyName = "ligne1")]
        public string ligne1 { get; set; } 
        // TEXT (0 , 50)
        [JsonProperty(PropertyName = "ligne2")]
        public string ligne2 { get; set; } 
        // TEXT (0 , 50)
        [JsonProperty(PropertyName = "ligne3")]
        public string ligne3 { get; set; } 
        // TEXT (3 , 160)
        [JsonProperty(PropertyName = "courriel")]
        public string courriel { get; set; } 
        [JsonProperty(PropertyName = "adresse")]        
        public AdresseViewModel adresse { get; set; }
        [JsonProperty(PropertyName = "telfix")]
        public NumtelViewModel telfix { get; set; }
        [JsonProperty(PropertyName = "portable")]
        public NumtelViewModel portable { get; set; }
        [JsonProperty(PropertyName = "fax")]
        public NumtelViewModel fax { get; set; }
        [JsonProperty(PropertyName = "web")]
        public WebViewModel web { get; set; }
    }
}