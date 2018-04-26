using AppCocacolaNay2.Models.Inventarios;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppCocacolaNay2.Interfaces.SQLite
{
    public interface ISQLiteService
    {
        Task<IList<zt_inventarios>> GetAll();
        Task Insert(zt_inventarios zt_Inventarios);
        Task Remove(zt_inventarios zt_Inventarios);
    }
}
