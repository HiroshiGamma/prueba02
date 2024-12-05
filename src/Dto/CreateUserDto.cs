using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace api02.src.Dto
{
    public class CreateUserDto
    {
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Correo { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Date)]
        [CustomValidation(typeof(CreateUserDto), nameof(ValidateFechaNacimiento))]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        [RegularExpression("^(Femenino|Masculino|Prefiero no decirlo|Otro)$")]
        public string Genero { get; set; } = string.Empty;

        public static ValidationResult ValidateFechaNacimiento(DateTime fechaNacimiento, ValidationContext context)
        {
            if (fechaNacimiento >= DateTime.Now)
            {
                return new ValidationResult("FechaNacimiento must be a past date.");
            }
            return ValidationResult.Success!;
        }
    }
}