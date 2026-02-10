using ListaDeTarefas.Application.Abstractions;
using ListaDeTarefas.Domain.Entities;
using ListaDeTarefas.Infrastructure.Database;
using Microsoft.Data.SqlClient;
using System.Data;

namespace ListaDeTarefas.Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataBase _db;
        public CategoryRepository(DataBase db) => _db = db;

        public async Task<bool> ExistsCategoryAsync(string name)
        {

            using (SqlConnection conn = _db.GetSqlConnection())
            {
                await conn.OpenAsync();

                /*TROCAR NOME DAS TABELAS DEPOIS DE CRIAR O BANCO*/
                string sql = @"SELECT COUNT(*)
                                 FROM CATEGORIES C
                                WHERE C.CAT_NAME = @Name";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@Name", SqlDbType.VarChar, 100).Value = name;

                    var qtd = Convert.ToInt32(await cmd.ExecuteScalarAsync());

                    return qtd > 0;
                }
            }
        }

        public async Task<int> AddCategoryAsync(Category category)
        {
            using (SqlConnection conn = _db.GetSqlConnection())
            {
                await conn.OpenAsync();


                string sql = @"INSERT INTO CATEGORIES(CAT_NAME)
                                   OUTPUT INSERTED.CAT_ID
                                   VALUES (@Name)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@Name", SqlDbType.VarChar, 100).Value = category.Name;

                    var id = Convert.ToInt32(await cmd.ExecuteScalarAsync());

                    return id;
                }

            }
        }
    }
}
