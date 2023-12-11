using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo_App.Models;

namespace Todo_App.Data
{
    public class TodoItemDatabase
    {
        static SQLiteAsyncConnection Database;

        public static readonly AsyncLazy<TodoItemDatabase> Instance =
            new AsyncLazy<TodoItemDatabase>(async () =>
            {
                var instance = new TodoItemDatabase();
                try
                {
                    CreateTableResult result = await Database.CreateTableAsync<TodoItem>();
                }
                catch (Exception ex)
                {

                    throw;
                }
                return instance;
            });
    }
}
