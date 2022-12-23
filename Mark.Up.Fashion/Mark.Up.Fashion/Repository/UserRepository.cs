﻿using Dapper;
using Mark.Up.Fashion.Data;
using Mark.Up.Fashion.Models.Users;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mark.Up.Fashion.Repository
{
    public class UserRepository
    {
        

            private readonly MsqlConfig _connectionFactory;

            public UserRepository(MsqlConfig connectionFactory)
            {
                _connectionFactory = connectionFactory;
            }

            public async Task<IEnumerable<User>> GetAll()
            {
                using (var connection = _connectionFactory.Connection)
                {
                    connection.Open();
                    return await connection.QueryAsync<User>("SELECT * FROM users");
                }
            }

            public async Task<User> GetById(int id)
            {
                using (var connection = _connectionFactory.Connection)
                {
                    connection.Open();
                    return await connection.QueryFirstOrDefaultAsync<User>("SELECT * FROM users WHERE id = @Id", new { Id = id });
                }
            }

            public async Task Add(User user)
            {
                using (var connection = _connectionFactory.Connection)
                {
                    connection.Open();
                    await connection.ExecuteAsync("INSERT INTO persons (username, email, password, dob, address) VALUES (@Username, @Email, @Password, @Dob, @Address)", user);
                }
            }

            public async Task Update(User user)
            {
                using (var connection = _connectionFactory.Connection)
                {
                    connection.Open();
                    await connection.ExecuteAsync("UPDATE persons SET first_name = @FirstName, last_name = @LastName WHERE id = @Id", user);
                }
            }

            public async Task Delete(int id)
            {
                using (var connection = _connectionFactory.Connection)
                {
                    connection.Open();
                    await connection.ExecuteAsync("DELETE FROM users WHERE id = @Id", new { Id = id });
                }
            }
        }
}