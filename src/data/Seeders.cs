using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api02.src.models;
using Bogus;

namespace api02.src.data
{
    public class Seeders
    {
        public static void initialize(IServiceProvider serviceProvider)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var service = scope.ServiceProvider;
                var context =  service.GetRequiredService<ApplicationDBContext>();

                if (!context.Users.Any())
                {
                    var generos = new[] { "Femenino", "Masculino", "Prefiero no decirlo", "Otro" };
                    var userFaker = new Faker<User>()
                        .RuleFor(u => u.Id, f => f.IndexFaker + 1)
                        .RuleFor(u => u.Nombre, f => f.Name.FirstName())
                        .RuleFor(u => u.Correo, f => f.Internet.Email())
                        .RuleFor(u => u.FechaNacimiento, f => DateOnly.FromDateTime(f.Date.Past(30, DateTime.Now.AddYears(-18))))
                        .RuleFor(u => u.Genero, f => f.PickRandom(generos));

                    var users = userFaker.Generate(10).Select(u => {
                        u.FechaNacimiento = DateOnly.ParseExact(u.FechaNacimiento.ToString("dd/MM/yyyy"), "dd/MM/yyyy");
                        return u;
                    }).ToList();

                    context.Users.AddRange(users);
                    context.SaveChanges();
                }

                context.SaveChanges();
            }
        }
    }
}