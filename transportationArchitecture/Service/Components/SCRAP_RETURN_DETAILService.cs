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
    public class SCRAP_RETURN_DETAILService : Service.Framework.AbstractService
    {
        #region Constructor
        public SCRAP_RETURN_DETAILService()
        {
        }
        #endregion

        #region Overridden Properties
        public override AbstractDAO dao
        {
            get
            {
                return new DataAccess.Components.SCRAP_RETURN_DETAILDAO();
            }
        }
        #endregion        
    }
}
	