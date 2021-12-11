using Layers.Data.DTOStructData;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layers.Data.DAOEntities
{
    public class DAOTableEntitiesGroup : Connection, IDAO<DTOEntitiesGroup>
    {
        public void DeleteData(int id)
        {
            throw new NotImplementedException();
        }

        public List<DTOEntitiesGroup> GetData()
        {
            SqlDataReader reader = null;
            try 
            {
                command.Connection = connection;
                command.CommandText = "SELECT * FROM GruposEntidades";
                OpenConnection();

                reader = command.ExecuteReader();

                List<DTOEntitiesGroup> list = new List<DTOEntitiesGroup>();
                while (reader.Read()) 
                {
                    list.Add(new DTOEntitiesGroup 
                    {
                        IdGroupEntitie = (int)reader["idGrupoEntidad"],
                        DescriptionGroupEntitie = (string)reader["Descripcion"],
                        ComentaryGroupEntitie = (string)reader["Comentario"],
                        StatusGroupEntitie = (string)reader["Estatus"],
                        IsDeletedGroupEntitie = (bool)reader["NoEliminable"],
                        RegisterDateGroupEntitie = (string)reader["FechaRegistro"]
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

        public List<DTOEntitiesGroup> GetDataById(int id)
        {
            throw new NotImplementedException();
        }

        public DTOEntitiesGroup GetDataSpecify(string name, string password)
        {
            throw new NotImplementedException();
        }

        public void InsertData(DTOEntitiesGroup entitie)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(DTOEntitiesGroup entitie)
        {
            throw new NotImplementedException();
        }
    }
}
