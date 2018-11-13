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
    public class GOOD_TRANSPORTATIONService : Service.Framework.AbstractService
    {
        #region Constructor
        public GOOD_TRANSPORTATIONService()
        {
        }
        #endregion

        #region Overridden Properties
        public override AbstractDAO dao
        {
            get
            {
                return new DataAccess.Components.GOOD_TRANSPORTATIONDAO();
            }
        }
        #endregion        
    }
}
	