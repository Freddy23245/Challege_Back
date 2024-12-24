using ClienteChallenge.Interfaces;
using ClienteChallenge.Models;
using log4net;
using Microsoft.EntityFrameworkCore;

namespace ClienteChallenge.Datos
{
    public class ClientesData : IClienteService
    {
        private static readonly ILog _logger = LogManager.GetLogger(typeof(ClientesData));
        private ClienteChallengeContext _context;
        public ClientesData(ClienteChallengeContext context)
        {
            _context = context;
        }
        public async Task<Cliente> Get(int Id)
        {
            _logger.Info("Inicio del proceso Get.");
            try
            {
                Cliente result = await _context.Clientes.FindAsync(Id);
                return result;
            }
            catch (Exception ex)
            {
                _logger.Error($"Error durante el proceso Get", ex);
                throw;
            }
            finally
            {
                _logger.Info("Fin del proceso Get.");
            }
        }

        public async Task<IEnumerable<Cliente>> GetAll()
        {
            _logger.Info("Inicio del proceso GetAll.");
            try
            {
                return await _context.Clientes.ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.Error($"Error durante el proceso GetAll", ex);
                throw;
            }
            finally
            {
                _logger.Info("Fin del proceso GetAll.");
            }
      
        }

        public async Task Insert(Cliente cliente)
        {
            _logger.Info("Inicio del proceso Insert.");
            try
            {
                _context.Clientes.Add(cliente);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.Error($"Error durante el proceso Insert", ex);
                throw;
            }
            finally
            {
                _logger.Info("Fin del proceso Insert.");
            }
        }

        public async Task Update(Cliente cliente)
        {
            _logger.Info("Inicio del proceso Update.");
            try
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
            catch (Exception ex)
            {
                _logger.Error($"Error durante el proceso Update", ex);
                throw;
            }
            finally
            {
                _logger.Info("Fin del proceso Update.");
            }
        }

        async Task<IEnumerable<Cliente>> IClienteService.Search(string Name)
        {
            _logger.Info("Inicio del proceso Search.");
            try
            {
                IEnumerable<Cliente> clientes = await _context.Clientes.
                                                           Where(x => x.Nombres.Contains(Name)).
                                                           ToListAsync();
                return clientes;
            }
            catch (Exception ex)
            {
                _logger.Error($"Error durante el proceso Search", ex);
                throw;
            }
            finally
            {
                _logger.Info("Fin del proceso Search.");
            }
        }
    }
}
