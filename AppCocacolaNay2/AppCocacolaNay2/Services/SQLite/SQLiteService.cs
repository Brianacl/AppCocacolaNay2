using Xamarin.Forms;
using AppCocacolaNay2.Helpers;
using AppCocacolaNay2.Interfaces.SQLite;
using AppCocacolaNay2.Models.Inventarios;
using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppCocacolaNay2.Services.SQLite
{
    public class SQLiteService : ISQLiteService
    {
        private static readonly AsyncLock Mutex = new AsyncLock();
        private SQLiteAsyncConnection _sqlCon;

        public SQLiteService()
        {
            var databasePath = DependencyService.Get<IPathService>().GetDatabasePath();
            _sqlCon = new SQLiteAsyncConnection(databasePath);

            CreateDatabaseAsync();
        }//Fin constructor

        public async void CreateDatabaseAsync()
        {
            using (await Mutex.LockAsync().ConfigureAwait(false))
            {
                await _sqlCon.CreateTableAsync<zt_inventarios>().ConfigureAwait(false);
            }
        }//Fin createDataBaseAsync

        public async Task<IList<zt_inventarios>> GetAll()
        {
            var zt_inventarios = new List<zt_inventarios>();
            using (await Mutex.LockAsync().ConfigureAwait(false))
            {
                zt_inventarios = await _sqlCon.Table<zt_inventarios>().ToListAsync().ConfigureAwait(false);
            }

            return zt_inventarios;
        }//Fin GetAll

        public async Task Insert(zt_inventarios zt_inventarios)
        {
            using (await Mutex.LockAsync().ConfigureAwait(false))
            {
                var existingTodoItem = await _sqlCon.Table<zt_inventarios>()
                        .Where(x => x.Id == zt_inventarios.Id)
                        .FirstOrDefaultAsync();

                if (existingTodoItem == null)
                {
                    await _sqlCon.InsertAsync(zt_inventarios).ConfigureAwait(false);
                }
                else
                {
                    zt_inventarios.Id = existingTodoItem.Id;
                    await _sqlCon.UpdateAsync(zt_inventarios).ConfigureAwait(false);
                }
            }
        }//Fin insert

        public async Task Remove(zt_inventarios zt_inventarios)
        {
            await _sqlCon.DeleteAsync(zt_inventarios);
        }//Fin remove
    }
}
