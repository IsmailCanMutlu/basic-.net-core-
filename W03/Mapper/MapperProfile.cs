using AutoMapper;
using W03.Dtos;
using W03.Models;
using W03.PModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace W03.Mapper
{


    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<PostMoviePModel, Movie>();
            CreateMap<Movie, PostMoviePModel>();
            CreateMap<Movie, MovieDtos>();
            CreateMap<MovieDtos, Movie>();

            CreateMap<Content, ContentDtos>();
            CreateMap<ContentDtos, Content>();
            CreateMap<Content, PostContentPModel>();
            CreateMap<PostContentPModel, Content>();

            CreateMap<PostSeriesPModel, Series>();
            CreateMap<Series, PostSeriesPModel>();
            CreateMap<Series, SeriesDtos>();
            CreateMap<SeriesDtos, Series>();
        }
    }


}