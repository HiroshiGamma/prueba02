using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api02.src.data;
using api02.src.interfaces;
using api02.src.models;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;


namespace api02.src.repository
{
    public class UserRepository : iUserRepository
    {
        
        private readonly ApplicationDBContext _context; 

        public UserRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<User> Post(User user)
        {

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await _context.Users.ToListAsync();
        }

    }
}