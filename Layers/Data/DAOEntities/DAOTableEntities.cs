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
                        TypeEntitieEntitie = (bool)reader["TipoEntidad"],
                        DocumentNumberEntitie = (int)reader["TipoDocumento"],
                        PhoneEntitie = reader["Telefonos"].ToString(),
                        UrlWebEntitie = reader["UrlPaginaWeb"].ToString(),
                        UrlFacebookEntitie = reader["UrlFacebook"].ToString(),
                        UrlInstagramEntitie = reader["UrlInstagram"].ToString(),
                        UrlTikTokEntitie = reader["UrlTwitter"].ToString(),
                        UrlTwitterEntitie = reader["FechaRegistro"].ToString(),
                        IdEntitieGroup = reader["FechaRegistro"].ToString(),
                        IdTypeEntitie = reader["FechaRegistro"].ToString(),
                        CrediteLimitEntitie = reader["FechaRegistro"].ToString(),
                        UrlWebEntitie = reader["FechaRegistro"].ToString(),
                        UserNameEntitie = reader["FechaRegistro"].ToString(),
                        PasswordEntitie = reader["FechaRegistro"].ToString(),
                        RoleUserEntitie = reader["FechaRegistro"].ToString(),
                        ComentaryEntitie = reader["FechaRegistro"].ToString(),
                        StatusEntitie = reader["FechaRegistro"].ToString(),
                        IsDeletedEntitie = reader["FechaRegistro"].ToString(),
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
            throw new NotImplementedException();
        }

        public void UpdateData(DTOEntities entitie)
        {
            throw new NotImplementedException();
        }
    }
}
