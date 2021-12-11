using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layers.Data.DTOStructData;

namespace Layers.Data.DAOEntities
{
    public class DAOTableEntitiesTypes : Connection, IDAO<DTOEntitieTypes>
    {
        public void DeleteData(int id)
        {
            throw new NotImplementedException();
        }

        public List<DTOEntitieTypes> GetData()
        {
            SqlDataReader reader = null;
            try
            {
                command.Connection = connection;
                command.CommandText = "SELECT * FROM TiposEntidades";
                OpenConnection();

                reader = command.ExecuteReader();

                List<DTOEntitieTypes> list = new List<DTOEntitieTypes>();
                while (reader.Read())
                {
                    list.Add(new DTOEntitieTypes
                    {
                       /* IdGroupEntitie = (int)reader["idGrupoEntidad"],
                        DescriptionGroupEntitie = (string)reader["Descripcion"],
                        ComentaryGroupEntitie = (string)reader["Comentario"],
                        StatusGroupEntitie = (string)reader["Estatus"],
                        IsDeletedGroupEntitie = (bool)reader["NoEliminable"],
                        RegisterDateGroupEntitie = (string)reader["FechaRegistro"].ToString()*/
                    });
                }
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                reader.Close();
                CloseConnection();
            }

            return null;
        }

        public List<DTOEntitieTypes> GetDataById(int id)
        {
            throw new NotImplementedException();
        }

        public DTOEntitieTypes GetDataSpecify(string name, string password)
        {
            throw new NotImplementedException();
        }

        public void InsertData(DTOEntitieTypes entitie)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(DTOEntitieTypes entitie)
        {
            throw new NotImplementedException();
        }
    }
}
