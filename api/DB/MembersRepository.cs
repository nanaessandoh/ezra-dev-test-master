using System;
using System.Collections.Generic;
using System.Linq;

using EzraTest.Models;

using Microsoft.Data.Sqlite;

namespace EzraTest.DB
{
    public class MembersRepository : IMembersRepository
    {
        private string _connectionString;

        public MembersRepository(string connectionString)
        {
            _connectionString = $"Data Source={connectionString}";
        }

        /// <inheritdoc />
        public IEnumerable<Member> GetMembers()
        {
            return ExecuteQuery("SELECT * FROM MEMBERS", (reader) =>
            {
                return new Member
                {
                    Id = reader.GetGuid(0),
                    Name = reader.GetString(1),
                    Email = reader.GetString(2)
                };
            });
        }

        /// <inheritdoc />
        public Member GetMember(Guid id)
        {
            return ExecuteQuery($"SELECT * FROM MEMBERS WHERE Id = '{id:N}'", (reader) =>
            {
                return new Member
                {
                    Id = Guid.Parse(reader.GetString(0)),
                    Name = reader.GetString(1),
                    Email = reader.GetString(2)
                };
            }).FirstOrDefault();
        }

        /// <inheritdoc />
        public void AddMember(Member member)
        {

            using (var connection = new SqliteConnection(_connectionString))
            {
                // TODO
                if (member != null)
                {
                    connection.Open();
                    var insertCmd = connection.CreateCommand();
                    insertCmd.CommandText = $"INSERT INTO MEMERS(Id, Name, Email) VALUES('{member.Id}','{member.Name}', '{member.Email}')";
                    insertCmd.ExecuteNonQuery();

                }
                connection.Close();
            }

        }

        /// <inheritdoc />
        public void UpdateMember(Guid id, Member member)
        {
            // TODO
            using (var connection = new SqliteConnection(_connectionString))
            {
                if (member != null)
                {
                    connection.Open();
                    var updateCmd = connection.CreateCommand();
                    updateCmd.CommandText = $"UPDATE MEMBERS SET Name = '{member.Name}', Email = '{member.Email}' WHERE Id = '{id}' ";
                    updateCmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        /// <inheritdoc />
        public void DeleteMember(Guid id)
        {
            // TODO
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var deleteCmd = connection.CreateCommand();
                deleteCmd.CommandText = $"DELETE FROM MEMBERS WHERE Id = '{id}' ";
                deleteCmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        private IEnumerable<T> ExecuteQuery<T>(string commandText, Func<SqliteDataReader, T> func)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = commandText;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        yield return func(reader);
                    }
                }
            }
        }
    }
}