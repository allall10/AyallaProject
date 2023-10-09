//using Bll;
//using Microsoft.AspNetCore.Cors;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace projectAyallaEfratNoa.Controllers
//{

//    [Route("api/[controller]")]
//    [ApiController]
//    [EnableCors]
//    public class UserController : ControllerBase
//    {
//        [HttpGet(Name = "GetAllUsers")]

//        public IEnumerable<User1Tbl> GetAllUsers()
//        {
//            return UserBll.GetUserAllAsync();
//        }

////[HttpGet(Name = "deleteUser")]
////public IEnumerable<User1Tbl> deleteUser()
////{
////    return new List<User1Tbl>();
////}

////[HttpGet(Name = "GetUser")]
////public IEnumerable<User1Tbl> GetUser()
////{
////    return new List<User1Tbl>();
////}


////[HttpGet(Name = "{id}")]
////public User1Tbl Get(string id)
////{
////    return this.User.get
////}



//public UserBll userBll;
//public UserController(UserBll motherBll)
//{
//    this.userBll = motherBll;
//}

//// GET: api/<UserController>
//[HttpGet]
////public List<UserBll> Get(string id)
////{
////    return userBll.GetUsers;
////}

//// GET api/<UserMotherController>/5



//// POST api/<UserMotherController>
//[HttpPost]
////public void Post([FromBody] string value)
////{
////}

//// PUT api/<UserMotherController>/5
//[HttpPut("{id}")]
//public void Put(string id)
//{
//}

//// DELETE api/<UserMotherController>/5
//[HttpDelete("{id}")]
//public void Delete(string id)
//{
//}
//    }
//}
