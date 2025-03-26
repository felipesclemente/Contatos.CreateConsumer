using Contatos.CreateConsumer.Interfaces;
using Contatos.DataContracts.Commands;
using Dapper;
using Npgsql;
using Serilog;

namespace Contatos.CreateConsumer.Repository
{
    public class ContatoRepository : IContatoRepository
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public ContatoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("Postgres") ?? string.Empty;
        }

        public async Task AdicionarContatoAsync(CadastrarContato contato)
        {
            try
            {
                var nomeCompleto = contato.NomeCompleto;
                var ddd = contato.DDD;
                var telefone = contato.Telefone;
                var email = contato.Email;
                
                using var connection = new NpgsqlConnection(_connectionString);
                var queryString = @"INSERT INTO Contato (NomeCompleto, DDD, Telefone, Email)
                                    VALUES (@nomeCompleto, @ddd, @telefone, @email)";
                var result = await connection.ExecuteAsync(queryString, new { nomeCompleto, ddd, telefone, email });
                Console.WriteLine($"Operação concluída. Linhas afetadas: {result}.");
            }
            catch (Exception ex)
            {
                Log.Error($"ContatoRepository: Falha ao cadastrar novo contato. Exception: {ex.GetType()}. Message: {ex.Message}.");
                Console.WriteLine($"ContatoRepository: Falha ao cadastrar novo contato. Exception: {ex.GetType()}. Message: {ex.Message}.");
            }
        }
    }
}
