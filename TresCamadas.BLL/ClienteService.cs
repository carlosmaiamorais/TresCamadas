using TresCamadas.DAL.Repositories;
using TresCamadas.Model;

namespace TresCamadas.BLL
{
    public class ClienteService
    {
        private readonly ClienteRepository _clienteRepository;
        public ClienteService(ClienteRepository repository)
        {
            _clienteRepository = repository;
        }

        public void CadastrarCliente(Cliente c)
        {

            //Regras de negócio

            //1 º Se já existe o CPF cadastrado
            var achouCpf = _clienteRepository.ExisteCpfNaBase(c.Cpf);
            if (achouCpf)
                throw new ArgumentException("CPF já existe cadastrado na base de dados.");

            _clienteRepository.Cadastrar(c);            
        }

        public List<Cliente> ObterTodos()
        {            
            var listaCliente = _clienteRepository.ObterTodos();
            return listaCliente;
        }

        public void AtualizarCliente(Cliente param)
        {
            var cliente = _clienteRepository.ObterPorId(param.Id);
            if (cliente == null)
                throw new ArgumentException("Cliente não encontrado na base para atualizar.");

            cliente.Nome = param.Nome;
            cliente.Idade = param.Idade;
            cliente.DataNascimento = param.DataNascimento;

            _clienteRepository.Atualizar(cliente);
            
        }

        public void ExcluirCliente(long id)
        {
            var cliente = _clienteRepository.ObterPorId(id);
            if (cliente == null)
                throw new ArgumentException("Cliente não encontrado na base para atualizar.");

            _clienteRepository.Excluir(cliente);
        }


    }
}
