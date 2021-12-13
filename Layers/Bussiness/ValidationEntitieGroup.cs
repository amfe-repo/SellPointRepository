using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layers.Data.DAOEntities;
using Layers.Data.DTOStructData;

namespace Layers.Bussiness
{
    public class ValidationEntitieGroup
    {

        public List<DTOEntitiesGroup> ViewData()
        {
            DAOTableEntitiesGroup oDAO = new DAOTableEntitiesGroup();
            return oDAO.GetData();
        }

        public void DeleteData(int id)
        {
            DAOTableEntitiesGroup oDAO = new DAOTableEntitiesGroup();
            oDAO.DeleteData(id);
        }

        public void AddGroup(string description, string commentary, string status, bool isDelete)
        {
            DTOEntitiesGroup oDTO = new DTOEntitiesGroup();

            oDTO.DescriptionGroupEntitie = description;
            oDTO.ComentaryGroupEntitie = commentary;
            oDTO.StatusGroupEntitie = status;
            oDTO.IsDeletedGroupEntitie = isDelete;

            DAOTableEntitiesGroup oDAO = new DAOTableEntitiesGroup();
            oDAO.InsertData(oDTO);       
        }

        public void ModifyGroup(string description, string commentary, string status, bool isDelete, int id)
        {

            DTOEntitiesGroup oDTO = new DTOEntitiesGroup();

            oDTO.DescriptionGroupEntitie = description;
            oDTO.ComentaryGroupEntitie = commentary;
            oDTO.StatusGroupEntitie = status;
            oDTO.IsDeletedGroupEntitie = isDelete;
            oDTO.IdGroupEntitie = id;

            DAOTableEntitiesGroup oDAO = new DAOTableEntitiesGroup();
            oDAO.UpdateData(oDTO);

        }
    }
}
