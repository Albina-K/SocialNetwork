using SocialNetwork.BLL.Services;
using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using NUnit.Framework;
using NUnit;
using SocialNetwork.DAL.Repositories;
using SocialNetwork.Pll.Views;
using SocialNetwork.DAL.Entities;


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
                Email = "gmail10@gmail.com"
               // Password = "fffffff"
            };
            
            Assert.Throws<UserNotFoundException>(() => userService.Authenticate(userAuthenticationData));
        }
    }
}