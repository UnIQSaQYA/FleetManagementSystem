using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DataAccess.Components;
using DataAccess.Framework;
using DataHelper.Framework;
using Entity.Components;
using Entity.Framework;
using Service.Framework;
namespace Service.Components
{
    public class VEHICLE_CATEGORY_TYPEService : Service.Framework.AbstractService
    {
        
        #region Constructor
        public VEHICLE_CATEGORY_TYPEService()
        {
        }
        #endregion

        #region Overridden Properties
        public override AbstractDAO dao
        {
            get
            {
                return new DataAccess.Components.VEHICLE_CATEGORY_TYPEDAO();
            }
        }
        #endregion        
    }
}
