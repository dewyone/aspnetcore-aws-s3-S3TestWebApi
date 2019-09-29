using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using S3TestWebApi.Models;
using S3TestWebApi.Services;

namespace S3TestWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class S3BucketController : Controller
    {
        private readonly IS3Service _service;

        public S3BucketController(IS3Service service)
        {
            _service = service;
        }

        [HttpPost("CreateBucket/{bucketName}")]
        public async Task<IActionResult> CreateBucket([FromRoute] string bucketName)
        {
            var response = await _service.CreateBucketAsync(bucketName);

            return Ok(response);
        }

        [HttpPost]
        [Route("AddFile/{bucketName}")]
        public async Task<IActionResult> AddFile([FromRoute] string bucketName)
        {
            await _service.UploadFileAsync(bucketName);

            return Ok();
        }



        [HttpPost]
        public IActionResult CreateBucket02([FromBody] string bucketName)
        {
            //var response = await _service.CreateBucketAsync(bucketName);


            return Ok(new S3Response
            {
                Message = "CreateBucket02",
                Status = System.Net.HttpStatusCode.OK
            }) ;
        }
    }
}