using System;
using System.Collections.Generic;
using System.Text;
using Refit;
using System.Threading.Tasks;
using AwesomeSeries.Models;

namespace AwesomeSeries.Infra.Api
{
    [Headers("Content-Type: Application/json")]
    public interface ITmdbApi
    {
        [Get("/tv/popular?api_key={apiKey}")]
        Task<SerieResponse> GetSerieResponseAsync(string apiKey);
    }

}
