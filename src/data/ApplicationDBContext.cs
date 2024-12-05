using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api02.src.models;
using Microsoft.EntityFrameworkCore;

namespace api02.src.data
{
    public class ApplicationDBContext (DbContextOptions dbContextOptions) : DbContext(dbContextOptions)
    {
        
        public List<User> Users {get; set;} = null!; 
        public List<Genero> Generos {get; set;} = null!;

    }
}