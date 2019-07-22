using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
            Expression<Func<UserProfile, bool>> filter = null;

            if (!string.IsNullOrEmpty(region))
            {
                if (!string.IsNullOrEmpty(industry))
                {
                    filter = profile => profile.Industry == industry && profile.Region == region;
                }
                else
                {
                    filter = profile => profile.Region == region;
                }
            }
            else if(!string.IsNullOrEmpty(industry))
            {
                filter = profile => profile.Industry == industry;
            }

            var res = _userRepo.GetList(filter);
            return Ok(res);
        }

        [HttpPut]
        [ResponseType(typeof(bool))]
        [Route("users")]
        public IHttpActionResult UpdateUser(UserProfile userProfile)
        {
            _userRepo.Update(userProfile);
            return Ok();
        }

        [HttpPost]
        [ResponseType(typeof(bool))]
        [Route("users")]
        public IHttpActionResult CreateUser(UserProfile userProfile)
        {
            _userRepo.Insert(userProfile);
            return Ok();
        }
    }
}
