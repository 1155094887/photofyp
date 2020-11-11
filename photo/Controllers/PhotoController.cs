using System;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using photo.Data;
using photo.Dto;
using photo.Models;

namespace photo.Controllers
{
    [Route("api/photo")]
    [ApiController]
    public class PhotoController : ControllerBase
    {
        private readonly IPhotoRepository _photoRepository;
        private readonly IMapper _mapper;

        public PhotoController(IPhotoRepository photoRepository,IMapper mapper)
        {
            _photoRepository = photoRepository;
            _mapper = mapper;
        }
        //get all photos
        [HttpGet]
        public ActionResult<IEnumerable<PhotoGetRp>> GetAllPhotos()
        {
            var all_photo = _photoRepository.GetAllPhotos();
            return Ok(_mapper.Map<IEnumerable<PhotoGetRp>>(all_photo));
        }
        //get photo by id
        [HttpGet("{id}")]
        public ActionResult<PhotoGetRp> GetPhotoById(int id)
        {
            var photo = _photoRepository.GetPhotoById(id);
            if (photo == null)
                return NotFound();
            return _mapper.Map<PhotoGetRp>(photo);
        }
        //post photo api
        //should return rp
        public ActionResult<PhotoAddRp> AddPhoto(PhotoAddRt rt)
        {
            var photo = _mapper.Map<Photo>(rt);
            _photoRepository.AddPhoto(photo);
            _photoRepository.SaveChanges();

            return Ok(_mapper.Map<PhotoAddRp>(photo));
        }
    }
}
