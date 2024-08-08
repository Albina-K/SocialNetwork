using SocialNetwork.BLL.Services;
using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using NUnit.Framework;
using NUnit;

namespace SocialNetwork.Tests
{
    [TestFixture]
    public class UserServiceTests
    {   
        [Test]
        public void Authenticate_MustThrowException()
        {
            UserService userService = new UserService();
            UserAuthenticationData userAuthenticationData = new UserAuthenticationData()
            {
                Email = "gmail2@gmail.com",
                Password = "fffffff"
            };            
            Assert.Throws<WrongPasswordException>(() => userService.Authenticate(userAuthenticationData));
        }
    }
}