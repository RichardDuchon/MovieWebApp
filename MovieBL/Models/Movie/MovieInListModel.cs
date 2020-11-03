using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieBL.Models.Movie
{
    public class MovieInListModel
    {
        [JsonProperty("popularity")]
        public double Popularity { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("adult")]
        public bool Adult { get; set; }

        [JsonProperty("original_language")]
        public string OriginalLanguage { get; set; }

        [JsonProperty("original_title")]
        public string OriginalTitle { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
        
    }
}
