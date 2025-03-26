using Contatos.DataContracts.Commands;

namespace Contatos.CreateConsumer.Interfaces
{
    public interface IContatoRepository
    {
        Task AdicionarContatoAsync(CadastrarContato contato);
    }
}
