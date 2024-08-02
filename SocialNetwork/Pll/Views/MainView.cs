﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialNetwork.BLL.Models;

namespace SocialNetwork.Pll.Views
{
    public class MainView
    {
        public void Show()
        {
            Console.WriteLine("Войти в профиль (нажмите 1)");
            Console.WriteLine("Зарегестрироваться (нажмите 2)");

            switch (Console.ReadLine())
            {
                case "1":
                    {
                        Program.authenticationView.Show();
                        break;
                    }
                case "2":
                    {
                        Program.registrationView.Show();
                        break;
                    }
            }
        }
    }
}
