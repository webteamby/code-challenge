using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Results;
using BsvService.Api.Controllers;
using BsvService.Core.Models;
using BsvService.DAL.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BsvService.UnitTest
{
    [TestClass]
    public class UnitTest
    {
        static IUserRepo repo = new TestUserRepo();
        static UserController controller = new UserController(repo);

        [TestMethod]
        public void TestMethod1()
        {

            IHttpActionResult actionResult = controller.GetUser(10);
            var contentResult = actionResult as OkNegotiatedContentResult<UserProfile>;

            Assert.IsNotNull(contentResult);
            Assert.IsNull(contentResult.Content);
        }

        [TestMethod]
        public void TestMethod2()
        {

            IHttpActionResult actionResult = controller.GetUser(1);
            var contentResult = actionResult as OkNegotiatedContentResult<UserProfile>;

            Assert.IsNotNull(contentResult);
            Assert.IsNotNull(contentResult.Content);
        }

        [TestMethod]
        public void TestMethod3()
        {

            IHttpActionResult actionResult = controller.GetUsers();
            var contentResult = actionResult as OkNegotiatedContentResult<List<UserProfile>>;

            Assert.IsNotNull(contentResult);
            Assert.IsNotNull(contentResult.Content);
        }
    }
}
