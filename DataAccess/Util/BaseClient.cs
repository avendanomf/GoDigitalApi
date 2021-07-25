using Entities.Movies;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;

namespace DataAccess.Util
{
    public class BaseClient
    {
        protected readonly string _endpoint;
        public BaseClient(string endpoint)
        {
            _endpoint = endpoint;
        }
        public MoviesEntity GetLastMovies<T>(out HttpStatusCode statusCode, Dictionary<string, string> parameters = null)
        {
            using (var httpClient = new HttpClient())
            {
                var endpoint = _endpoint;
                if (parameters != null)
                {
                    endpoint += "?";
                    string _parameters = string.Empty;
                    int iCount = 0;
                    foreach (var item in parameters)
                    {
                        iCount++;
                        _parameters += string.Format("{0}={1}", item.Key, item.Value);
                        if (parameters.Count() != iCount)
                            _parameters += "&";
                    }
                    endpoint += _parameters;
                }
                var response = httpClient.GetAsync(endpoint).Result;
                statusCode = response.StatusCode;
                if (statusCode == HttpStatusCode.OK)
                    return JsonConvert.DeserializeObject<MoviesEntity>(response.Content.ReadAsStringAsync().Result);
                else
                    return default(MoviesEntity);
            }
        }

        public popularMoviesEntity GetPopularMovies<T>(out HttpStatusCode statusCode, Dictionary<string, string> parameters = null)
        {
            using (var httpClient = new HttpClient())
            {
                var endpoint = _endpoint;
                if (parameters != null)
                {
                    endpoint += "?";
                    string _parameters = string.Empty;
                    int iCount = 0;
                    foreach (var item in parameters)
                    {
                        iCount++;
                        _parameters += string.Format("{0}={1}", item.Key, item.Value);
                        if (parameters.Count() != iCount)
                            _parameters += "&";
                    }
                    endpoint += _parameters;
                }
                var response = httpClient.GetAsync(endpoint).Result;
                statusCode = response.StatusCode;
                if (statusCode == HttpStatusCode.OK)
                    return JsonConvert.DeserializeObject<popularMoviesEntity>(response.Content.ReadAsStringAsync().Result);
                else
                    return default(popularMoviesEntity);
            }
        }

        public popularMoviesEntity GetTopRatedMovies<T>(out HttpStatusCode statusCode, Dictionary<string, string> parameters = null)
        {
            using (var httpClient = new HttpClient())
            {
                var endpoint = _endpoint;
                if (parameters != null)
                {
                    endpoint += "?";
                    string _parameters = string.Empty;
                    int iCount = 0;
                    foreach (var item in parameters)
                    {
                        iCount++;
                        _parameters += string.Format("{0}={1}", item.Key, item.Value);
                        if (parameters.Count() != iCount)
                            _parameters += "&";
                    }
                    endpoint += _parameters;
                }
                var response = httpClient.GetAsync(endpoint).Result;
                statusCode = response.StatusCode;
                if (statusCode == HttpStatusCode.OK)
                    return JsonConvert.DeserializeObject<popularMoviesEntity>(response.Content.ReadAsStringAsync().Result);
                else
                    return default(popularMoviesEntity);
            }
        }

    }
}