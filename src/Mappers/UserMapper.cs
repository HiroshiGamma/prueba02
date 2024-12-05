using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api02.src.Dto;
using api02.src.models;

namespace api02.src.Mappers
{
    public static class UserMapper
    {
        public static User ToUser(this CreateUserDto createUserDto)
        {
            return new User
            {
                Nombre = createUserDto.Nombre,
                Correo = createUserDto.Correo,
                FechaNacimiento = System.DateOnly.FromDateTime(createUserDto.FechaNacimiento),
                Genero = createUserDto.Genero
            };
        }
    }
}