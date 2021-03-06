﻿using AutoMapper;
using photo.Dto;
using photo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace photo.sProfile
{
    public class PhotoProfile : Profile
    {
        public PhotoProfile()
        {
            CreateMap<Photo, PhotoGetRt>();
            CreateMap<Photo, PhotoAddRt>();
            CreateMap<Photo, PhotoAddRp>();
            CreateMap<PhotoAddRt, Photo>();
        }
    }
}
