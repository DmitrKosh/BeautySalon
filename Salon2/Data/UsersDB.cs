using Salon2.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Salon2.Data
{
    public class UsersDB
    {
        readonly SQLiteAsyncConnection db;

        public UsersDB(string connectionString)
        {
            db = new SQLiteAsyncConnection(connectionString);

            db.CreateTableAsync<User>().Wait();
        }

        public Task<List<User>> GetUsersAsync() //получение всех пользователей
        {
            return db.Table<User>().ToListAsync();
        }

        public Task<User> GetUserAsyncLogin(string login, string password) //по логину и паролю
        {
            return db.Table<User>()
                .Where(i => i.Login == login && i.Password == password)
                .FirstOrDefaultAsync();
        }

        public Task<User> GetUserAsyncId(int id) //по id
        {
            return db.Table<User>()
                .Where(i => i.ID == id)
                .FirstOrDefaultAsync();
        }

        public Task<int> SaveUserAsync(User user) //сохранение данных пользователя
        {
            if (user.ID != 0)
            {
                return db.UpdateAsync(user);
            }
            else
            {
                return db.InsertAsync(user);
            }
        }

        public Task<int> DeleteUser(User user)
        {
            return db.DeleteAsync(user);
        }
    }
}