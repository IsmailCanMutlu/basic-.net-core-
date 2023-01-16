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
    public class SeriesController : ControllerBase
    {

        [HttpGet]
        public ActionResult<List<PostSeriesPModel>> Get()
        {
            using (var context = new Contex())
            {
                var contents = context.Seriess.Select(data => new PostSeriesPModel()
                {

                    Id = data.Id,
                    Content_Id = data.Content_Id,
                    Name = data.Name,
                    Season = data.Seison,
                    Genre = data.Genre,
                    Views= data.Views
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
        public ActionResult<PostSeriesPModel> Post(Series series)
        {
            using (var context = new Contex())
            {
                if (series != null && series.Name != null)
                {
                    context.Seriess.Add(series);
                    context.SaveChanges();

                    return new PostSeriesPModel()
                    {
                        Id = series.Id,
                        Content_Id = series.Content_Id,
                        Name = series.Name,
                        Views = series.Views,
                        Genre=series.Genre,
                        Season=series.Seison
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

