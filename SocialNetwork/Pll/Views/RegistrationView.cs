using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.Pll.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Pll.Views
{
    public class RegistrationView
    {
        UserService userService;
        public RegistrationView(UserService userService)
        {
            this.userService = userService;
        }
        public void Show()
        {
            var userRegistrationData = new UserRegistrationData();

            Console.WriteLine("Для создания нового профиля введите Ваше имя: ");
            userRegistrationData.FirstName = Console.ReadLine();           
            
            Console.WriteLine("Ваша фамилия: ");
            userRegistrationData.LastName = Console.ReadLine();
            
            Console.WriteLine("Пароль: ");
            userRegistrationData.Password = Console.ReadLine();  
            
            Console.WriteLine("Почтовый адрес: ");
            userRegistrationData.Email = Console.ReadLine();

            try
            {
                this.userService.Register(userRegistrationData);

                SuccessMessage.Show("Ваш профиль успешно создан.Теперь вы можете войти в систему под своими учетными данными.");
            }

            catch (ArgumentNullException)
            {
                AlertMessage.Show("Введите корректное значение");
            }

            catch (Exception)
            {
                AlertMessage.Show("Произошла ошибка при регистрации.");
            }
        }
    }
}
