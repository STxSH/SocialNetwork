using SocialNetwork.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class UserFriendView
    {
        public void Show(IEnumerable<User> friends)
        {
            Console.WriteLine("\nДрузья:\n");

            if (friends.Count() == 0)
            {
                Console.WriteLine("Список друзей пуст");
                return;
            }

            foreach (var friend in friends)
            {
                Console.WriteLine("---");
                Console.WriteLine($"Почтовый адрес: {friend.Email}");
                Console.WriteLine($"Имя: {friend.FirstName}");
                Console.WriteLine($"Фамилия: {friend.LastName}");
                Console.WriteLine("---\n");
            }
        }
    }
}
