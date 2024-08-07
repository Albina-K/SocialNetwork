using SocialNetwork.BLL.Services;
using NUnit;
using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;

namespace SocialNetwork.Tests.BLL.Services
{
    [TestFixture]
    public class UserServiceTests
    {
        private UserService userService;
        private UserAuthenticationData userAuthenticationData;

        public UserServiceTests()
        {
            userService = new UserService();
            userAuthenticationData = new UserAuthenticationData();
        }
        [Test]
        public void Authenticate_MustThrowException()
        {
            var userService = new UserService();
            var userAuthenticationData = new UserAuthenticationData()
            {
                Email = "gmail2@gmail.com",
                Password = "fffffff"
            };
      
            Assert.Throws<WrongPasswordException>(() => userService.Authenticate(userAuthenticationData));
        }        
    }
}