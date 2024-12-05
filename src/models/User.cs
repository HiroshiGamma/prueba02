using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api02.src.models;

namespace api02.src.models
{
    public class User
    {
        public int id {get; set;} 

        public string nombre {get; set;} = string.Empty;

        public string correo {get; set;} = string.Empty;

        public DateOnly fechaNacimiento {get; set;} = new DateOnly();

        public Genero Genero {get; set;} = null!; 
    }
}