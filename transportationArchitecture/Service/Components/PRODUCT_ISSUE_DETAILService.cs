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
    public class PRODUCT_ISSUE_DETAILService : Service.Framework.AbstractService
    {
        #region Constructor
        public PRODUCT_ISSUE_DETAILService()
        {
        }
        #endregion

        #region Overridden Properties
        public override AbstractDAO dao
        {
            get
            {
                return new DataAccess.Components.PRODUCT_ISSUE_DETAILDAO();
            }
        }
        #endregion        
    }
}
	