using Layers.Data.DTOStructData;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layers.Data.DAOEntities
{
    public class DAOTableEntitieType : Connection, IDAO<DTOEntitiesGroup>
    {
        public void DeleteData(int id)
        {
            try
            {
                command.Connection = connection;
                command.CommandText = "DELETE FROM GruposEntidades" +
                    " WHERE idGrupoEntidad = @id";

                command.Parameters.AddWithValue("@id", id);
                OpenConnection();

                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
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
                        RegisterDateGroupEntitie = (string)reader["FechaRegistro"].ToString()
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
            SqlDataReader reader = null;
            try
            {
                command.Connection = connection;
                command.CommandText = "SELECT * FROM GruposEntidades WHERE idGrupoEntidad = @id";
                command.Parameters.AddWithValue("@id", id);
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

        public DTOEntitiesGroup GetDataSpecify(string name, string password)
        {
            throw new NotImplementedException();
        }

        public void InsertData(DTOEntitiesGroup entitie)
        {
            try
            {
                command.Connection = connection;
                command.CommandText = "INSERT INTO GruposEntidades(Descripcion, Comentario, Estatus, NoEliminable)" +
                    "VALUES(@desc, @com, @est, @elim)";
                command.Parameters.AddWithValue("@desc", entitie.DescriptionGroupEntitie);
                command.Parameters.AddWithValue("@com", entitie.ComentaryGroupEntitie);
                command.Parameters.AddWithValue("@est", entitie.StatusGroupEntitie);
                command.Parameters.AddWithValue("@elim", entitie.IsDeletedGroupEntitie);
                OpenConnection();

                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }

        }

        public void UpdateData(DTOEntitiesGroup entitie)
        {
            try
            {
                command.Connection = connection;
                command.CommandText = "UPDATE GruposEntidades SET Descripcion = @desc, Comentario = @com, Estatus = @est, NoEliminable = @elim" +
                    " WHERE idGrupoEntidad = @id";
                command.Parameters.AddWithValue("@desc", entitie.DescriptionGroupEntitie);
                command.Parameters.AddWithValue("@com", entitie.ComentaryGroupEntitie);
                command.Parameters.AddWithValue("@est", entitie.StatusGroupEntitie);
                command.Parameters.AddWithValue("@elim", entitie.IsDeletedGroupEntitie);
                command.Parameters.AddWithValue("@id", entitie.IdGroupEntitie);
                OpenConnection();

                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
