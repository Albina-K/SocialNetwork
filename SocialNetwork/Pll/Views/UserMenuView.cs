﻿using SocialNetwork.BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialNetwork.BLL.Models;

namespace SocialNetwork.Pll.Views
{
    public class UserMenuView
    {
        UserService userService;
        public UserMenuView(UserService userService)
        {
            this.userService = userService;
        }
        public void Show(User user)
        {
            while (true)
            {
                Console.WriteLine("Входящие сообщения: {0}", user.IncomingMessages.Count());
                Console.WriteLine("Исходящие сообщения: {0}", user.OutgoingMessages.Count());

                Console.WriteLine("Посмотреть информацию о моем профиле (нажмите 1)");
                Console.WriteLine("Редактировать мой профиль (нажмите 2)");
                Console.WriteLine("Добавить в друзья (нажмите 3)");
                Console.WriteLine("Посмотреть моих друзей (нажмите 4)");
                Console.WriteLine("Написать сообщение (нажмите 5)");
                Console.WriteLine("Просмотреть входящие сообщения (нажмите 6)");
                Console.WriteLine("Просмотреть исходящие сообщения (нажмите 7)");
                Console.WriteLine("Выйти из профиля (нажмите 8)");

                string keyValue = Console.ReadLine();

                if (keyValue == "8") break;

                switch (keyValue)
                {
                    case "1":
                        {
                            Program.userInfoView.Show(user); break;
                        }
                    case "2":
                        {
                            Program.userDataUpdateView.Show(user); 
                            break;
                        }
                    case "3":
                        {
                            Program.addingFriendView.Show(user); break;
                        }
                    case "4":
                        {
                            Program.userFriendView.Show(user.Friends); break;
                        }
                    case "5":
                        {
                            Program.messageSendingView.Show(user); break;
                        }
                    case "6":
                        {
                            Program.userIncomingMessageView.Show(user.IncomingMessages); break;
                        }
                    case "7":
                        {
                            Program.userOutcomingMessageView.Show(user.OutgoingMessages); break;
                        }
                }
            }
        }
    }
}
