using System;
using System.Data;
using System.Collections.Generic;
using System.Text;

using DataAccess.Components;
using DataAccess.Framework;
using DataHelper.Framework;
using Entity.Components;
using Entity.Framework;
using Service.Framework;

namespace Service.Components
{
    public class VEHICLE_ISSUE_RETURNService : Service.Framework.AbstractService
    {
        #region Constructor
        public VEHICLE_ISSUE_RETURNService()
        {
        }
        #endregion

        #region Overridden Properties
        public override AbstractDAO dao
        {
            get
            {
                return new DataAccess.Components.VEHICLE_ISSUE_RETURNDAO();
            }
        }
        #endregion        
    }
}
	