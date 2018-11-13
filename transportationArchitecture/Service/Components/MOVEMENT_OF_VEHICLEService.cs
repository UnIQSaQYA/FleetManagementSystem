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
    public class MOVEMENT_OF_VEHICLEService : Service.Framework.AbstractService
    {
        #region Constructor
        public MOVEMENT_OF_VEHICLEService()
        {
        }
        #endregion

        #region Overridden Properties
        public override AbstractDAO dao
        {
            get
            {
                return new DataAccess.Components.MOVEMENT_OF_VEHICLEDAO();
            }
        }
        #endregion        
    }
}
	