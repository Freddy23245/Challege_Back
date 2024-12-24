using ClienteChallenge.Models;

namespace ClienteChallenge.Interfaces
{
    public interface IClienteService
    {
        Task<IEnumerable<Cliente>> GetAll();
        Task<Cliente> Get(int Id);
        Task<IEnumerable<Cliente>> Search(string Name);
        Task Insert(Cliente cliente);
        Task Update(Cliente cliente);
    }
}
