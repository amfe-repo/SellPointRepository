using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layers.Data.DTOStructData;

namespace Layers.Data.DAOEntities
{
    public class DAOTableEntities : Connection, IDAO<DTOEntities>
    {
        public void DeleteData(int id)
        {
            throw new NotImplementedException();
        }

        public List<DTOEntities> GetData()
        {
            SqlDataReader reader = null;
            try
            {
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Entidades";
                OpenConnection();

                reader = command.ExecuteReader();

                List<DTOEntities> list = new List<DTOEntities>();

                while (reader.Read())
                {
                    list.Add(new DTOEntities
                    {
                        IdEntitie = (int)reader["idTipoEntidad"],
                        DescriptionEntitie = (string)reader["Descripcion"],
                        DirecctionEntitie = (string)reader["Direccion"],
                        LocalityEntitie = (string)reader["Localidad"],
                        TypeEntitieEntitie = (string)reader["TipoEntidad"],
                        TypeDocumentEntitie = (string)reader["TipoDocumento"],
                        DocumentNumberEntitie = (int)reader["NumeroDocumento"],
                        PhoneEntitie = reader["Telefonos"].ToString(),
                        UrlWebEntitie = reader["UrlPaginaWeb"].ToString(),
                        UrlFacebookEntitie = reader["UrlFacebook"].ToString(),
                        UrlInstagramEntitie = reader["UrlInstagram"].ToString(),
                        UrlTwitterEntitie = reader["UrlTwitter"].ToString(),
                        UrlTikTokEntitie = reader["UrlTikTok"].ToString(),
                        IdEntitieGroup = int.Parse(reader["idGrupoEntidad"].ToString()),
                        IdTypeEntitie = int.Parse(reader["idTipoEntidad"].ToString()),
                        CrediteLimitEntitie = decimal.Parse(reader["LimiteCredito"].ToString()),
                        UserNameEntitie = reader["UserNameEntidad"].ToString(),
                        PasswordEntitie = reader["PasswordEntidad"].ToString(),
                        RoleUserEntitie = reader["RoluserEntidad"].ToString(),
                        ComentaryEntitie = reader["Comentario"].ToString(),
                        StatusEntitie = reader["Estatus"].ToString(),
                        IsDeletedEntitie = (bool)reader["NoEliminable"],
                        RegisterDateEntitie = reader["FechaRegistro"].ToString()
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

        public List<DTOEntities> GetDataById(int id)
        {
            throw new NotImplementedException();
        }

        public DTOEntities GetDataSpecify(string name, string password)
        {
            throw new NotImplementedException();
        }

        public void InsertData(DTOEntities entitie)
        {
            try
            {
                command.Connection = connection;
                command.CommandText = "INSERT INTO Entidades(idEntidad, Descripcion, Direccion, Localidad, TipoEntidad, TipoDocumento, NumeroDocumento, Telefonos, URLPaginaWeb, URLFacebook, URLInstagram, URLTikTok, idGrupoEntidad, idTipoEntidad, LimiteCredito, UserNameEntidad, RolUserEntidad, Comentario, Estatus, NoEliminable, FechaRegistro) " +
                    "VALUES(@idE, @desc, @direcc, @Local, @TipE, @TipoD, @NumeroD, @Tel, @URLP, @URLFace, @URLInst, @Twitt, @URLTik, @idGroup, @idTipoE, @LimiteC, @UserNE, @PassE, @RolUE, @com, @est, @elim, @FechaReg)";
                command.Parameters.AddWithValue("@idE", entitie.IdEntitie);
                command.Parameters.AddWithValue("@desc", entitie.DescriptionEntitie);
                command.Parameters.AddWithValue("@direcc", entitie.DirecctionEntitie);
                command.Parameters.AddWithValue("@Local", entitie.LocalityEntitie);
                command.Parameters.AddWithValue("@TipE", entitie.TypeEntitieEntitie);
                command.Parameters.AddWithValue("@TipoD", entitie.TypeDocumentEntitie);
                command.Parameters.AddWithValue("@NumeroD", entitie.DocumentNumberEntitie);
                command.Parameters.AddWithValue("@Tel", entitie.PhoneEntitie);
                command.Parameters.AddWithValue("@URLP", entitie.UrlWebEntitie);
                command.Parameters.AddWithValue("@URLFace", entitie.UrlFacebookEntitie);
                command.Parameters.AddWithValue("@URLInst", entitie.UrlInstagramEntitie);
                command.Parameters.AddWithValue("@Twitt", entitie.UrlTwitterEntitie);
                command.Parameters.AddWithValue("@URLTik", entitie.UrlTikTokEntitie);
                command.Parameters.AddWithValue("@idGroup", entitie.IdEntitieGroup);
                command.Parameters.AddWithValue("@idTipoE", entitie.IdTypeEntitie);
                command.Parameters.AddWithValue("@LimiteC", entitie.CrediteLimitEntitie);
                command.Parameters.AddWithValue("@UserNE", entitie.UserNameEntitie);
                command.Parameters.AddWithValue("@PassE", entitie.PasswordEntitie);
                command.Parameters.AddWithValue("@RolUE", entitie.RoleUserEntitie);
                command.Parameters.AddWithValue("@com", entitie.ComentaryEntitie);
                command.Parameters.AddWithValue("@est", entitie.StatusEntitie);
                command.Parameters.AddWithValue("@elim", entitie.IsDeletedEntitie);
                command.Parameters.AddWithValue("@FechaReg", entitie.RegisterDateEntitie);
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

        public void UpdateData(DTOEntities entitie)
        {
            try
            {
                command.Connection = connection;
                command.CommandText = "UPDATE TiposEntidades SET Descripcion = @desc, idGrupoEntidad = @idGroup, Comentario = @com, Estatus = @est, NoEliminable = @elim" +
                    " WHERE idTipoEntidad = @id";
                /*command.Parameters.AddWithValue("@desc", entitie.DescriptionTypeEntitie);
                command.Parameters.AddWithValue("@com", entitie.ComentaryTypeEntitie);
                command.Parameters.AddWithValue("@est", entitie.StatusTypeEntitie);
                command.Parameters.AddWithValue("@elim", entitie.IsDeletedTypeEntitie);
                command.Parameters.AddWithValue("@idGroup", entitie.IdEntitieGroup);
                command.Parameters.AddWithValue("@id", entitie.IdTypeEntitie);*/
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
