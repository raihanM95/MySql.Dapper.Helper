using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySql.Dapper.Helper.Core
{
    public static class GenericRepository<T> where T : class
    {
        public static async Task<int> AddAsync(string connectionString, string query, T entity)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(query, entity);
                connection.Close();
                return result;
            }
        }

        public static async Task<IReadOnlyList<T>> GetAllAsync(string connectionString, string query)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var result = await connection.QueryAsync<T>(query);
                connection.Close();
                return result.ToList();
            }
        }

        public static async Task<T> GetByIdAsync(string connectionString, string query, int id)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var result = await connection.QuerySingleOrDefaultAsync<T>(query, new { Id = id });
                connection.Close();
                return result;
            }
        }

        public static async Task<int> UpdateAsync(string connectionString, string query, T entity)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(query, entity);
                connection.Close();
                return result;
            }
        }

        public static async Task<int> DeleteAsync(string connectionString, string query, int id)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(query, new { Id = id });
                connection.Close();
                return result;
            }
        }

        public static async Task<T> GetUserAsync(string connectionString, string query, string username, string password)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var result = await connection.QuerySingleOrDefaultAsync<T>(query, new { Username = username, Password = password });
                connection.Close();
                return result;
            }
        }
    }
}
