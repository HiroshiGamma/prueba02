using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api02.src.models;

namespace api02.src.models
{
    public class User
    {
        public int Id {get; set;}
        public string Nombre {get; set;} = string.Empty;
        public string Correo {get; set;} = string.Empty;
        public DateOnly FechaNacimiento {get; set;} = new DateOnly();
        public string Genero {get; set;} = string.Empty; 
    }
}