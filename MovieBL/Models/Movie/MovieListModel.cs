using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;


namespace MovieBL.Models.Movie
{
    public class MovieListModel
    {
        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("results")]
        public List<MovieInListModel> MovieInListModels { get; set; }
    }
}
