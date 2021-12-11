using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layers.Data.DTOStructData;

namespace Layers.Data.DAOEntities
{
    interface IDAO<T>
    {
        List<T> GetData();
        List<T> GetDataById(int id);
        void InsertData(T entitie);
        void UpdateData(T entitie);
        void DeleteData(int id);
        T GetDataSpecify(string name, string password);

    }
}
