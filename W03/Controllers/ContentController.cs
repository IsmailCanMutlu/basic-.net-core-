using System;
using System.Collections.Generic;
using System.Linq;
using W03.Dtos;
using W03.Models;
using W03.PModels;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace W02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContentController : ControllerBase
    {

        private readonly IMapper _mapper;
        public ContentController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<Content> Get()
        {
            using (var context = new Contex())
            {
                return context.Contents.ToList();
            }

        }

        [HttpGet("{id}")]
        public ActionResult<Content> Get(int id)
        {
            using (var context = new Contex())
            {
                var contents = context.Contents.Where(data => data.Id == id).FirstOrDefault();
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
        public ActionResult<ContentDtos> Post(Content contents)
        {
            using (var context = new Contex())
            {
                if (contents != null && contents.Name != null)
                {
                    context.Add(contents);
                    context.SaveChanges();


                    return _mapper.Map<ContentDtos>(contents);

                }
                else
                {
                    return BadRequest();
                }
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<Content> Delete(int id)
        {
            using (var context = new Contex())
            {
                var data = context.Contents.Where(data => data.Id == id).FirstOrDefault();

                if (data == null)
                {
                    return NotFound();
                }
                else
                {
                    context.Contents.Remove(data);
                    context.SaveChanges();
                    return data;
                }
            }

        }
    }



}

