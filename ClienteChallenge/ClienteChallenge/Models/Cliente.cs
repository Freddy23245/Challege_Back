using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ClienteChallenge.Models
{
    public partial class Cliente
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo Nombres es obligatorio.")]
        [StringLength(50, ErrorMessage = "El campo Nombres no puede tener más de 50 caracteres.")]
        public string Nombres { get; set; } = null;
        [Required(ErrorMessage = "El campo Apellidos es obligatorio.")]
        [StringLength(80, ErrorMessage = "El campo Apellidos no puede tener más de 80 caracteres.")]
        public string Apellidos { get; set; } = null!;
        [Required]
        [DataType(DataType.Date)]
        public DateTime? FechaNacimiento { get; set; }
        [Required(ErrorMessage = "El campo CUIT es obligatorio.")]
        [RegularExpression(@"^\d{2}-\d{8}-\d{1}$", ErrorMessage = "El CUIT debe tener el formato XX-XXXXXXXX-X.")]
        public string Cuit { get; set; } = null!;
        [StringLength(50, ErrorMessage = "El campo Domicilio no puede tener más de 50 caracteres.")]
        public string Domicilio { get; set; } = null!;
        [Required(ErrorMessage = "El campo Teléfono Celular es obligatorio.")]
        [Phone(ErrorMessage = "El número de teléfono no tiene el formato válido.")]
        [StringLength(10, ErrorMessage = "El campo 10 no puede tener más de 10 caracteres.")]
        public string Celular { get; set; } = null!;
        [Required(ErrorMessage = "El campo Email es obligatorio.")]
        [EmailAddress(ErrorMessage = "El Email no tiene el formato correcto.")]
        public string Email { get; set; } = null!;
    }
}
