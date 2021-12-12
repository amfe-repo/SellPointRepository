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
            try
            {
                command.Connection = connection;
                command.CommandText = "DELETE FROM TiposEntidades" +
                    " WHERE idTipoEntidad = @id";
                command.Parameters.AddWithValue("@id", id);

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
                        IdTypeEntitie = (int)reader["idTipoEntidad"],
                        DescriptionTypeEntitie = (string)reader["Descripcion"],
                        ComentaryTypeEntitie = (string)reader["Comentario"],
                        StatusTypeEntitie = (string)reader["Estatus"],
                        IsDeletedTypeEntitie = (bool)reader["NoEliminable"],
                        IdEntitieGroup = (int)reader["idGrupoEntidad"],
                        RegisterDateTypeEntitie = reader["FechaRegistro"].ToString()
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
            SqlDataReader reader = null;
            try
            {
                command.Connection = connection;
                command.CommandText = "SELECT * FROM TiposEntidades WHERE @id";
                command.Parameters.AddWithValue("@id", id);
                OpenConnection();

                reader = command.ExecuteReader();

                List<DTOEntitieTypes> list = new List<DTOEntitieTypes>();
                while (reader.Read())
                {
                    list.Add(new DTOEntitieTypes
                    {
                        IdTypeEntitie = (int)reader["idTipoEntidad"],
                        DescriptionTypeEntitie = (string)reader["Descripcion"],
                        IdEntitieGroup = (int)reader["idGrupoEntidad"],
                        ComentaryTypeEntitie = (string)reader["Comentario"],
                        StatusTypeEntitie = (string)reader["Estatus"],
                        IsDeletedTypeEntitie = (bool)reader["NoEliminable"],
                        RegisterDateTypeEntitie = reader["FechaRegistro"].ToString()
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

        public DTOEntitieTypes GetDataSpecify(string name, string password)
        {
            throw new NotImplementedException();
        }

        public void InsertData(DTOEntitieTypes entitie)
        {
            try
            {
                command.Connection = connection;
                command.CommandText = "INSERT INTO TiposEntidades(Descripcion, idGrupoEntidad, Comentario, Estatus, NoEliminable)" +
                    "VALUES(@desc, @idGroup, @com, @est, @elim)";
                command.Parameters.AddWithValue("@desc", entitie.DescriptionTypeEntitie);
                command.Parameters.AddWithValue("@com", entitie.ComentaryTypeEntitie);
                command.Parameters.AddWithValue("@est", entitie.StatusTypeEntitie);
                command.Parameters.AddWithValue("@elim", entitie.IsDeletedTypeEntitie);
                command.Parameters.AddWithValue("@idGroup", entitie.IdEntitieGroup);
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

        public void UpdateData(DTOEntitieTypes entitie)
        {
            try
            {
                command.Connection = connection;
                command.CommandText = "UPDATE TiposEntidades SET Descripcion = @desc, idGrupoEntidad = @idGroup, Comentario = @com, Estatus = @est, NoEliminable = @elim" +
                    " WHERE idTipoEntidad = @id";
                command.Parameters.AddWithValue("@desc", entitie.DescriptionTypeEntitie);
                command.Parameters.AddWithValue("@com", entitie.ComentaryTypeEntitie);
                command.Parameters.AddWithValue("@est", entitie.StatusTypeEntitie);
                command.Parameters.AddWithValue("@elim", entitie.IsDeletedTypeEntitie);
                command.Parameters.AddWithValue("@idGroup", entitie.IdEntitieGroup);
                command.Parameters.AddWithValue("@id", entitie.IdTypeEntitie);
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
