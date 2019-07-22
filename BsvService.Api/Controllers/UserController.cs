using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using BsvService.Core.Models;
using BsvService.DAL.Repositories;

namespace BsvService.Api.Controllers
{
    public class UserController : ApiController
    {
        private readonly IUserRepo _userRepo;
        public UserController(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        [HttpGet]
        [ResponseType(typeof(List<UserProfile>))]
        [Route("users/{id:int}")]
        public IHttpActionResult GetUser(int id)
        {
            var res = _userRepo.Get(id);
            return Ok(res);
        }

        [HttpGet]
        [ResponseType(typeof(List<UserProfile>))]
        [Route("users")]
        public IHttpActionResult GetUsers([FromUri]string region=null, [FromUri]string industry = null)
        {
            Expression<Func<UserProfile, bool>> filter = profile =>
                (string.IsNullOrEmpty(industry) || profile.Industry.ToLower(CultureInfo.InvariantCulture) == industry.ToLower(CultureInfo.InvariantCulture)) &&
                (string.IsNullOrEmpty(region) || profile.Region.ToLower(CultureInfo.InvariantCulture) == region.ToLower(CultureInfo.InvariantCulture));

            var res = _userRepo.GetList(filter);
            return Ok(res);
        }

        [HttpPut]
        [Route("user")]
        public IHttpActionResult UpdateUser(UserProfile userProfile)
        {
            _userRepo.Update(userProfile);
            return Ok();
        }

        [HttpPost]
        [Route("user")]
        public IHttpActionResult CreateUser(UserProfile userProfile)
        {
            _userRepo.Insert(userProfile);
            return Ok();
        }

        [HttpDelete]
        [Route("users/{id:int}")]
        public IHttpActionResult DeleteUser(int id)
        {
            _userRepo.Delete(id);
            return Ok();
        }
    }
}
