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
    public class MODEL_YEARService : Service.Framework.AbstractService
    {
        #region Constructor
        public MODEL_YEARService()
        {
        }
        #endregion

        #region Overridden Properties
        public override AbstractDAO dao
        {
            get
            {
                return new DataAccess.Components.MODEL_YEARDAO();
            }
        }
        #endregion        
    }
}
	