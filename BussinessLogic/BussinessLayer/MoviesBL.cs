using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Movies;
using Entities.Utilities;
using DataAccess.AccessLayer;

namespace Bussiness.BussinessLayer
{
    public class MoviesBL
    {
        private MoviesDA moviesda_ = new MoviesDA();
        public MoviesEntity GetLastMovies(ConfigRequest configRequest)
        {
            try
            {
                return moviesda_.GetLastMovies(configRequest);
            }
            finally
            {
            }
        }

        public popularMoviesEntity GetPopularMovies(ConfigRequest configRequest)
        {
            try
            {
                return moviesda_.GetPopularMovies(configRequest);
            }
            finally
            {
            }
        }
        public popularMoviesEntity GetTopRatedMovies(ConfigRequest configRequest)
        {
            try
            {
                return moviesda_.GetTopRatedMovies(configRequest);
            }
            finally
            {
            }
        }
    }
}
