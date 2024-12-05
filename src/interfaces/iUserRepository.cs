using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api02.src.models;

namespace api02.src.interfaces
{
    public interface iUserRepository
    {
        Task<List<User>> GetAllUsers();
        Task<User> Post(User user);
    }
}