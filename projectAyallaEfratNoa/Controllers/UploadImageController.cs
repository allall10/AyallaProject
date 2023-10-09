using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using projectAyallaEfratNoa.Modules;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace projectAyallaEfratNoa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadImageController : ControllerBase
    {
        public static IWebHostEnvironment _environment;
        public UploadImageController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }
        // GET: api/<UploadImageController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<UploadImageController>/5
        [HttpGet("{imageName}")]
        public IActionResult Get(string imageName)
        {
            Byte[] b;
            if(imageName == null)
            {
                return Content("Hi there is no type value given. Please enter picture!");
            }
            else
            {
                b = System.IO.File.ReadAllBytes(_environment.WebRootPath + "//images//" +imageName);
            }
            return File(b, "image/jpeg");
        }

        // POST api/<UploadImageController>
        [HttpPost]
        public Task<FileUploadImage> Post([FromForm] FileUploadImage objFile)
        {
            FileUploadImage obj = new FileUploadImage();
            try
            {
                obj.ImgID = objFile.ImgID;
                obj.ImgName = "\\images\\" + objFile.files.FileName;
                if (objFile.files.Length > 0)
                {
                    if (!Directory.Exists(_environment.WebRootPath + "\\images"))
                    {
                        Directory.CreateDirectory(_environment.WebRootPath + "\\images\\");
                    }
                    using (FileStream filestream = System.IO.File.Create(_environment.WebRootPath + "\\images\\" + objFile.files.FileName))
                    {
                        objFile.files.CopyTo(filestream);
                        filestream.Flush();
                    }
                }
            }
            catch (Exception eX)
            {
                throw;
            }
            return Task.FromResult(obj);
        }
        // PUT api/<UploadImageController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UploadImageController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
