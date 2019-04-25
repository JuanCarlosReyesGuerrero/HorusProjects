using Horus.Common.Clases;
using Horus.Entities;
using System;
using System.Collections.Generic;
using System.Data;


namespace Horus.Common.Seguridad
{
    public class ClassValidaRoles
    {
        public PermisoOpcionMenu ValidaRoles(int idMenu)        
        {
            PermisoOpcionMenu dtRoles = LoginInfo.VgPermisosRoles.Find(x => x.MenuId.Equals(idMenu));          

            return dtRoles;
        }
    }
}
