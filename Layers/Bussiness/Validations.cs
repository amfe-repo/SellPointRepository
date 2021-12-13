using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layers.Data.DAOEntities;
using Layers.Data.DTOStructData;

namespace Layers.Bussiness
{
    public abstract class Validations<DAO, DTO>
    {
        private readonly DAO oDAO;
        private DTO oDTO;

        public abstract List<DTO> ViewData();
        public abstract void DeleteData(int id);

    }
}
