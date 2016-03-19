using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace ProductsApp.Controllers
{
    public class MoviesController : ApiController
    {
        public Movie[] movies = new Movie[] 
        { 
            new Movie { Id = 1, Name = "Suspiria", Review = 5, Note = "A great horror movie. The soundtrack is epic!" }, 
            new Movie { Id = 2, Name = "Halloween", Review = 4, Note = "A great good movie. I wish Carpented still made these."}, 
            new Movie { Id = 3, Name = "Sharknado II", Review = 1, Note = "This is just terrible horror movie. Where did those sharks even come from?" },
            new Movie { Id = 4, Name = "Shining", Review = 3, Note = "This is a good movie. Just a little bit overrated maybe." } 
        };

        public IEnumerable<Movie> GetAllMovies()
        {
            return movies;
        }

        public IHttpActionResult GetMovie(int id)
        {
            var movie = movies.FirstOrDefault((p) => p.Id == id);
            if (movie == null)
            {
                return NotFound();
            }
            return Ok(movie);
        }
    }
}