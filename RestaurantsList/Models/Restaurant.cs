using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RestaurantsList.Models
{
    public class Restaurant
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; }
        public string Description { get; set;  }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Image { get; set; }
        public string ID { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Restaurant>(this);
    }
}
