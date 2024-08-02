using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.BLL.Models
{
    /// <summary>
    /// проверка данных для входа в соцсеть
    /// </summary>
    public class UserAuthenticationData
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
