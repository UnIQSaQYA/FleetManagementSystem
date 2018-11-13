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
    public class FUEL_ODOMETERService : Service.Framework.AbstractService
    {
        #region Constructor
        public FUEL_ODOMETERService()
        {
        }
        #endregion

        #region Overridden Properties
        public override AbstractDAO dao
        {
            get
            {
                return new DataAccess.Components.FUEL_ODOMETERDAO();
            }
        }
        #endregion        
    }
}
	