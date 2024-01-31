using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class AddFriendView
    {
        UserService userService;
        public AddFriendView(UserService userService)
        {
            this.userService = userService;
        }
        public void Show(User user)
        {
             try
            {
                var friend = new Friend();

                Console.WriteLine("Введите Email пользователя, которого хотите добавить в друзья:\n");

                friend.FriendEmail = Console.ReadLine();
                friend.UserId = user.Id;

                userService.AddFriend(friend);

                SuccessMessage.Show("Вы добавили пользователя в друзья!");
            }

            catch(UserNotFoundException)
            {
                AlertMessage.Show("Пользователя с таким Email не существует!");
            }
            
            catch(Exception)
            {
                AlertMessage.Show("Ошибка при добавлении пользователя в друзья!");
            }

        }

    }
}
