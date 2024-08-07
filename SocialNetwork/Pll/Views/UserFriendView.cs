using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialNetwork.BLL.Models;

namespace SocialNetwork.Pll.Views
{
    public class UserFriendView
    {
        public void Show(IEnumerable<User> friends)
        {
            Console.WriteLine("Мои друзья ({0}):", friends.Count());

            if (friends.Count() == 0)
            {
                Console.WriteLine("У вас пока нет друзей(" 
                    + "Вы можете это исправить, предложив им зарегистрироваться в нашей социальной сети :)");
                return;
            }

            friends.ToList().ForEach(friend =>
            {
                Console.WriteLine("Почтовый адрес друга: {0}. Имя друга: {1}. Фамилия друга: {2}", friend.Email, friend.FirstName, friend.LastName);
            });
        }
    }
}
