using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineWEbShop.ViewModel;
using OnlineWebVideoShop.ActionFilter;
using VideoModels;
using VideoServiceContract;

namespace OnlineWebVideoShop.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [AuthorizeFilterAttribute]
    [ApiExceptionAttribute]
      [ApiResultFilterAttribute]
      public class VideoController : ControllerBase
    {
            private readonly IVideoServiceContract _videoBusiness;
            

            public VideoController(IVideoServiceContract videoBusinessService )
            {
                  _videoBusiness = videoBusinessService;
                  
            }
            

            [HttpPost]
           
            public async Task<List<VideoModel>> getVideos()
            {
                  
                  return (await _videoBusiness.GetVideos());
            }

            [HttpPost]
            public async Task<bool> deleteVideo([FromBody]string text)
            {
                  return (await _videoBusiness.DeleteAsync(new Guid(text)));

            }

            [HttpPost]
            public async Task<bool> addVideo([FromBody] VideoModel video)
            {
                  return (await _videoBusiness.AddVideoAsync(video));
            }
            [HttpPost]
            public async Task<bool> updateVideo([FromBody] VideoModel video)
            {
                  return (await _videoBusiness.UpdateVideoAsync(video));
            }

      }
}