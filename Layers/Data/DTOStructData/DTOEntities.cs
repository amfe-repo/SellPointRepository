using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layers.Data.DTOStructData
{
    internal class DTOEntities
    {
        public int IdEntitie { get; set; }
        public string DescriptionEntitie { get; set; }
        public string DirecctionEntitie { get; set; }
        public string LocalityEntitie { get; set; }
        public string TypeEntitieEntitie { get; set; }
        public string TypeDocumentEntitie { get; set; }
        public decimal DocumentNumberEntitie { get; set; }
        public string PhoneEntitie { get; set; }
        public string UrlWebEntitie { get; set; }
        public string UrlFacebookEntitie { get; set; }
        public string UrlInstagramEntitie { get; set; }
        public string UrlTwitterEntitie { get; set; }
        public string UrlTikTokEntitie { get; set; }
        public int IdEntitieGroup { get; set; }
        public int IdTypeEntitie { set; get; }
        public decimal CrediteLimitEntitie { get; set; }
        public string UserNameEntitie { get; set; }
        public string PasswordEntitie { get; set; }
        public string RoleUserEntitie { get; set; }
        public string ComentaryEntitie { get; set; }
        public string StatusEntitie { get; set; }
        public bool IsDeletedEntitie { get; set; }
        public string RegisterDateEntitie { get; set; }
    }
}
