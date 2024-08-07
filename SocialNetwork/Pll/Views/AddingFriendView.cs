using SocialNetwork.BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialNetwork.BLL.Models;
using SocialNetwork.Pll.Helpers;
using SocialNetwork.BLL.Exceptions;

namespace SocialNetwork.Pll.Views
{
    public class AddingFriendView
    {
        UserService userService;
        public AddingFriendView(UserService userService)
        {
            this.userService = userService;
        }
        public void Show(User user)
        {
            try
            {
                var userAddingFriendData = new UserAddingFriendData();

                Console.WriteLine("ВВедите почтовый адрес пользователя которого хотите добавить в друзья: ");

                userAddingFriendData.FriendEmail = Console.ReadLine();
                userAddingFriendData.UserId = user.Id;

                this.userService.AddFriend(userAddingFriendData);

                SuccessMessage.Show("Вы успешно добавили пользователя в друзья");
            }
            catch(UserNotFoundException)
            {
                AlertMessage.Show("Пользователь с указанным почтовым адресом не зарегестрирован");
            }

            catch(Exception)
            {
                AlertMessage.Show("Произошла ошибка при добавлении пользователя!");
            }
        }
    }
}
