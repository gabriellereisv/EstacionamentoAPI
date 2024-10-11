using EstacionamentoAPI.Models;
using Dapper;
using MySql.Data.MySqlClient;
using System.Data;

namespace EstacionamentoAPI.Repositories
{
    public class EstacionamentoRepository
    {
        private readonly string _connectionString;

        public EstacionamentoRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        private IDbConnection Connection =>
            new MySqlConnection(_connectionString);

        public async Task<IEnumerable<Veiculo>> ListarVeiculosEstacionados()
        {
            using (var conn = Connection)
            {
                var sql = "SELECT * FROM Veiculos vei JOIN Vagas vag on vag.VeiculoId = vei.id WHERE vag.Ocupada = true";

                    return await conn.QueryAsync<Veiculo>(sql);
                }
            }
        }
        //public async Task<Pessoa> BuscarPorId(int id)
        //{
        //    var sql = "SELECT * FROM tb_pessoas WHERE Id = @Id";

        //    using (var conn = Connection)
        //    {
        //        return await conn.QueryFirstOrDefaultAsync<Pessoa>(sql, new { Id = id });
        //    }
        //}

        //public async Task<int> DeletarPorId(int id)
        //{
        //    var sql = "DELETE FROM tb_pessoas WHERE Id = @Id";

        //    using (var conn = Connection)
        //    {
        //        return await conn.ExecuteAsync(sql, new { Id = id });
        //    }
        //}

        //public async Task<int> Salvar(Pessoa dados)
        //{
        //    var sql = "INSERT INTO tb_pessoas (Nome,Idade,Email) " +
        //        "values (@Nome,@Idade,@Email)";

        //    using (var conn = Connection)
        //    {
        //        return await conn.ExecuteAsync(sql,
        //            new
        //            {
        //                Nome = dados.Nome,
        //                Email = dados.Email,
        //                Idade = dados.Idade
        //            });
        //    }
        //}

        //public async Task<int> Atualizar(Pessoa dados)
        //{
        //    var sql = "UPDATE tb_pessoas set Nome = @Nome, Idade = @Idade, Email = @Email WHERE Id = @id";

        //    using (var conn = Connection)
        //    {
        //        return await conn.ExecuteAsync(sql, dados);
        //    }
        //}
    //    public async Task<bool> ValidaExistsEmail(string email)
    //    {
    //        var sql = "SELECT COUNT(*) FROM tb_pessoas WHERE Email = @Email";

    //        using (var conn = Connection)
    //        {
    //            return await conn.ExecuteScalarAsync<bool>(sql,
    //                new { Email = email });
    //        }
    //    }


    //}
}