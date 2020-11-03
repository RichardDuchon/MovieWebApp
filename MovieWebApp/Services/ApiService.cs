using MovieBL.Models.Movie;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using Microsoft.AspNetCore.Components;
using System.IO;

namespace MovieWebApp.Services
{
    public class ApiService
    {
        public HttpClient httpClient;
        public ApiService(HttpClient client)
        {
            httpClient = client;
        }

        public async Task<MovieListModel> GetListOfMoviesAsync(int nextOrPreviousPage)
        {
            
            DefaultRequestHeaders();

            HttpResponseMessage response = await httpClient.GetAsync($"movie/popular?api_key={ApiKey.ApiKey.apiKey}&language=en-US&page={nextOrPreviousPage}");

            return await response.Content.ReadAsAsync<MovieListModel>();
        }

        public async Task<MovieDetailModel> GetMovieDetailAsync(int movieId)
        {
            DefaultRequestHeaders();

            HttpResponseMessage response = await httpClient.GetAsync($"movie/{movieId}?api_key={ApiKey.ApiKey.apiKey}&language=en-US");

            return await response.Content.ReadAsAsync<MovieDetailModel>();
        }

        public void DefaultRequestHeaders()
        {
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
