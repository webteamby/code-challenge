using System.Collections.Generic;
using System.Linq;
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
            var contentResult = actionResult as OkNegotiatedContentResult<IEnumerable<UserProfile>>;

            Assert.IsNotNull(contentResult);
            Assert.IsNotNull(contentResult.Content);
            Assert.IsTrue(contentResult.Content.Count() == 3);


            actionResult = controller.GetUsers("Minsk");
            contentResult = actionResult as OkNegotiatedContentResult<IEnumerable<UserProfile>>;

            Assert.IsNotNull(contentResult);
            Assert.IsNotNull(contentResult.Content);
            Assert.IsTrue(contentResult.Content.Count() == 2);

            actionResult = controller.GetUsers(null, "IT");
            contentResult = actionResult as OkNegotiatedContentResult<IEnumerable<UserProfile>>;

            Assert.IsNotNull(contentResult);
            Assert.IsNotNull(contentResult.Content);
            Assert.IsTrue(contentResult.Content.Count() == 2);
        }
    }
}
