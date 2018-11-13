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
    public class login_fiscal_yearService : Service.Framework.AbstractService
    {
        #region Constructor
        public login_fiscal_yearService()
        {
        }
        #endregion

        #region Overridden Properties
        public override AbstractDAO dao
        {
            get
            {
                return new DataAccess.Components.login_fiscal_yearDAO();
            }
        }
        #endregion        
    }
}
	