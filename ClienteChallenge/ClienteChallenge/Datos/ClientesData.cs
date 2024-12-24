using ClienteChallenge.Interfaces;
using ClienteChallenge.Models;
using Microsoft.EntityFrameworkCore;

namespace ClienteChallenge.Datos
{
    public class ClientesData : IClienteService
    {
        private ClienteChallengeContext _context;
        public ClientesData(ClienteChallengeContext context)
        {
            _context = context;
        }
        public async Task<Cliente> Get(int Id)
        {
            Cliente result = await _context.Clientes.FindAsync(Id);
            return result;
        }

        public async Task<IEnumerable<Cliente>> GetAll()
        {
            return await _context.Clientes.ToListAsync();
      
        }

        public async Task Insert(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Cliente cliente)
        {
            var ClienteExistente = _context.Clientes.Find(cliente.Id);
            if (ClienteExistente == null)
            {
                throw new Exception($"No se encontró un cliente");
            }
            ClienteExistente.Nombres = cliente.Nombres;
            ClienteExistente.Apellidos = cliente.Apellidos;
            ClienteExistente.FechaNacimiento = cliente.FechaNacimiento;
            ClienteExistente.Cuit = cliente.Cuit;
            ClienteExistente.Domicilio = cliente.Domicilio;
            ClienteExistente.Celular = cliente.Celular;
            ClienteExistente.Email = cliente.Email;
          _context.Entry(ClienteExistente).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        async Task<IEnumerable<Cliente>> IClienteService.Search(string Name)
        {
            IEnumerable<Cliente> clientes = await _context.Clientes.
                                                               Where(x => x.Nombres.Contains(Name)).
                                                               ToListAsync();
            return clientes;
        }
    }
}
