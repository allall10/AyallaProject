using Microsoft.AspNetCore.Mvc;
using Bll;
using Dto;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace projectAyallaEfratNoa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessController : ControllerBase
    {      
        // GET: api/<BusinessController>
         IBusinessBll businessBll;
        private object _context;

        public BusinessController(IBusinessBll businessBll)
        {
            this.businessBll = businessBll;
        }

        [HttpGet("{id}")]
        public BusinessTblDto Get(string id)
        {
            return businessBll.GetBusinessById(id);
        }

        // GET api/<BusinessController>/5
        [HttpGet]
        public List<BusinessTblDto> Get()
        {
            return businessBll.GetBusinessAllAsync();
        }

        // POST api/<BusinessController>
        [HttpPost]
        public void Post([FromBody] BusinessTblDto value)
        {
            this.businessBll.AddBusinessAsync(value);
        }

        //PUT api/<BusinessController>/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] BusinessTblDto business)
        {   
            if (business == null || id != business.businessId)
            {
                Console.WriteLine("error!!");
            }
            var business1 = businessBll.GetBusinessById(id);
            if (business1 != null)
            {
                business.businessName = business1.businessName;
                business.businessIdCity = business1.businessIdCity;
                business.professionType = business1.professionType;
                business.languageId = business1.languageId;
                business.numWeekHours = business1.numWeekHours;
                business.seniorityBusiness = business1.seniorityBusiness;
                business.salaryHour = business1.salaryHour;
            }
            else
            {
                Console.WriteLine("not found!!");
            }
            //this._context.SaveChanges();
        }

        // DELETE api/<BusinessController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            businessBll.DeleteBusiness(id);
        }
    }
}
