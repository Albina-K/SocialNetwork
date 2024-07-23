using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialNetwork.DAL.Entities;

namespace SocialNetwork.DAL.Repositories
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public int Create(UserEntity userEntity)
        {
            return Execute(@"insert into users (firstname,lastname,password,email) 
                             values (:firstname,:lastname,:password,:email)", userEntity);
        }
    }
}
