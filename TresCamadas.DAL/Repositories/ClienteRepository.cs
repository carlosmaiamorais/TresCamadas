using TresCamadas.DAL.Context;
using TresCamadas.Model;

namespace TresCamadas.DAL.Repositories
{
    public class ClienteRepository
    {
        private readonly TresCamadasContext _context;

        public ClienteRepository(TresCamadasContext context)
        {
            _context = context;
        }

        public void Cadastrar(Cliente c)
        {
            _context.Clientes.Add(c);
            _context.SaveChanges();
        }

        public List<Cliente> ObterTodos()
        {            
            var lista = _context.Clientes.ToList();
            return lista;
        }

        public Cliente? ObterPorId(long paramId)
        {            
            var cliente = _context.Clientes.Where(x => x.Id == paramId).FirstOrDefault();
            return cliente;
        }

        public void Atualizar(Cliente c)
        {            
            _context.Clientes.Update(c);
            _context.SaveChanges();
        }

        public void Excluir(Cliente c)
        {
            _context.Clientes.Remove(c);
            _context.SaveChanges();
        }

        public bool ExisteCpfNaBase(string paramCpf)
        {
            return _context.Clientes.Where(x => x.Cpf == paramCpf).Any();            
        }

    }
}
