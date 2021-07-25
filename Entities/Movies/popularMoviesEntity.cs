using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Movies
{
    public class popularMoviesEntity
    {
        public int page { get; set; }
        public List<PopularMovieEntity> results { get; set; }
        public int total_pages { get; set; }
        public int total_results { get; set; }
    }
}
