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
    public class PURCHASE_ORDER_DETAILService : Service.Framework.AbstractService
    {
        #region Constructor
        public PURCHASE_ORDER_DETAILService()
        {
        }
        #endregion

        #region Overridden Properties
        public override AbstractDAO dao
        {
            get
            {
                return new DataAccess.Components.PURCHASE_ORDER_DETAILDAO();
            }
        }
        #endregion        
    }
}
	