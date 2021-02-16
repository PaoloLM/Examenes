using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EXPRACU1_Lizarraga.Models
{
    public class ClsUsuario
    {
        public string usuario { get; set; }
        public string contraseña { get; set; }
        public Boolean token { get; set; }
        public List<ClsUsuario> usuariosLogin { get; set; }
    }
}