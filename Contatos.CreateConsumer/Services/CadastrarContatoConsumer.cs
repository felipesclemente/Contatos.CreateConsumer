using Contatos.CreateConsumer.Interfaces;
using Contatos.DataContracts.Commands;
using MassTransit;

namespace Contatos.CreateConsumer.Services
{
    public class CadastrarContatoConsumer : IConsumer<CadastrarContato>
    {
        private readonly IContatoRepository _repoContato;

        public CadastrarContatoConsumer(IContatoRepository repoContato)
        {
            _repoContato = repoContato;
        }

        public async Task Consume(ConsumeContext<CadastrarContato> context)
        {
            Console.WriteLine(context.Message);
            await _repoContato.AdicionarContatoAsync(context.Message);
        }
    }
}
