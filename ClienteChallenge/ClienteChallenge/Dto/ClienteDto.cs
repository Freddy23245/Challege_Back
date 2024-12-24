using ClienteChallenge.Models;
using System.ComponentModel.DataAnnotations;

namespace ClienteChallenge.Dto
{
    public class ClienteDto
    {
        public int Id { get; set; }
        public string Nombres { get; set; } = null;
        public string Apellidos { get; set; } = null!;
        public DateTime? FechaNacimiento { get; set; }
       
        public string Cuit { get; set; } = null!;

        public string Domicilio { get; set; } = null!;

        public string Celular { get; set; } = null!;

        public string Email { get; set; } = null!;


        public static explicit operator ClienteDto(Cliente cliente)
        {
            return new ClienteDto
            {
                Id = cliente.Id,
                Nombres = cliente.Nombres,
                Apellidos = cliente.Apellidos,
                FechaNacimiento = cliente.FechaNacimiento,
                Cuit = cliente.Cuit,
                Domicilio = cliente.Domicilio,
                Celular = cliente.Celular,
                Email = cliente.Email
            };
        }

        public static explicit operator Cliente(ClienteDto clienteDto)
        {
            return new Cliente
            {
                Id = clienteDto.Id,
                Nombres = clienteDto.Nombres,
                Apellidos = clienteDto.Apellidos,
                FechaNacimiento = clienteDto.FechaNacimiento,
                Cuit = clienteDto.Cuit,
                Domicilio = clienteDto.Domicilio,
                Celular = clienteDto.Celular,
                Email = clienteDto.Email
            };
        }

    }

    

}
