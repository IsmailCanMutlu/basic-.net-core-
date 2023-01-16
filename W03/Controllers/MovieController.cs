using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using W03.Dtos;
using W03.Models;
using W03.PModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace W02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {

        [HttpGet]
        public ActionResult<List<PostMoviePModel>> Get()
        {
            using (var context = new Contex())
            {
                var contents = context.Movies.Select(data => new PostMoviePModel()
                {

                    Id = data.Id,
                    Content_Id = data.Content_Id,
                    Name = data.Name,
                    Director = data.Director,
                    Genre = data.Genre,
                    Views = data.Views
                }).ToList();
                if (contents == null)
                {
                    return NotFound();
                }
                else
                {
                    return contents;
                }
            }

        }



        [HttpPost]
        public ActionResult<PostMoviePModel> Post(Movie movie)
        {
            using (var context = new Contex())
            {
                if (movie != null && movie.Name != null)
                {
                    context.Movies.Add(movie);
                    context.SaveChanges();

                    return new PostMoviePModel()
                    {
                        Id = movie.Id,
                        Content_Id = movie.Content_Id,
                        Name = movie.Name,
                        Director = movie.Director,
                        Genre = movie.Genre,
                        Views = movie.Views
                    };
                }
                else
                {
                    return BadRequest();
                }
            }
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}

