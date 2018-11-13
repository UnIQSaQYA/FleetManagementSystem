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
    public class VEHICLE_AT_OFFICEService : Service.Framework.AbstractService
    {
        #region Constructor
        public VEHICLE_AT_OFFICEService()
        {
        }
        #endregion

        #region Overridden Properties
        public override AbstractDAO dao
        {
            get
            {
                return new DataAccess.Components.VEHICLE_AT_OFFICEDAO();
            }
        }
        #endregion        
    }
}
	