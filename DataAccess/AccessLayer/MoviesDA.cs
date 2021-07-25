using Entities.Movies;
using Entities.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.AccessLayer
{
    public class MoviesDA
    {
        public MoviesEntity GetLastMovies(ConfigRequest configRequest)
        {
            try
            {
                System.Net.HttpStatusCode status;
                MoviesEntity LstMovies = new MoviesEntity();
                Dictionary<string, string> parameter = new Dictionary<string, string>();
                parameter.Add("api_key", configRequest.ApiKey);
                parameter.Add("language", "en-US");                
                return new Util.BaseClient(configRequest.urlBase + "movie/latest").GetLastMovies<MoviesEntity>(out status, parameter);
            }
            finally
            {
            }      
        }
        public popularMoviesEntity GetPopularMovies(ConfigRequest configRequest)
        {
            try
            {
                System.Net.HttpStatusCode status;
                MoviesEntity LstMovies = new MoviesEntity();
                Dictionary<string, string> parameter = new Dictionary<string, string>();
                parameter.Add("api_key", configRequest.ApiKey);
                parameter.Add("language", "en-US");
                parameter.Add("page", "1");
                return new Util.BaseClient(configRequest.urlBase + "movie/popular").GetPopularMovies<popularMoviesEntity>(out status, parameter);
            }
            finally
            {
            }
        }

        public popularMoviesEntity GetTopRatedMovies(ConfigRequest configRequest)
        {
            try
            {
                System.Net.HttpStatusCode status;
                MoviesEntity LstMovies = new MoviesEntity();
                Dictionary<string, string> parameter = new Dictionary<string, string>();
                parameter.Add("api_key", configRequest.ApiKey);
                parameter.Add("language", "en-US");
                parameter.Add("page", "1");
                return new Util.BaseClient(configRequest.urlBase + "movie/top_rated").GetTopRatedMovies<popularMoviesEntity>(out status, parameter);
            }
            finally
            {
            }
        }
    }
}
