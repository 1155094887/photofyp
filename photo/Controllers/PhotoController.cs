using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using photo.Data;
using photo.Dto;
using photo.Models;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace photo.Controllers
{
    [Route("api/user")]
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
            return Ok();
        }
        //get photo by id
        [HttpGet("{id}")]
        public ActionResult<UserRt> GetAllProfileByUserId(int id)
        {
            var user = _photoRepository.GetProfileDesp(id);
            IQueryable<Photo> photos = _photoRepository.GetAllPhotosById(id);
            var rt_photo = _mapper.Map<List<PhotoGetRt>>(photos);
            UserRt userRp = new UserRt { Name = user.Name, Photos = rt_photo };
            if (photos == null)
                return NotFound();
            return userRp;
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
        [HttpPost]
        public ActionResult<char> UploadPhoto([FromForm]PhotoAddRt form)
        {
            //save photo
            var photo = _mapper.Map<Photo>(form);
            //hardcode
            photo.ByUserId = 1;
            _photoRepository.AddPhoto(photo);
            _photoRepository.SaveChanges();

            return 'a';
        }
    }
}
