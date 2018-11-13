﻿using System;
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
    public class PURCHASE_ORDERService : Service.Framework.AbstractService
    {
        #region Constructor
        public PURCHASE_ORDERService()
        {
        }
        #endregion

        #region Overridden Properties
        public override AbstractDAO dao
        {
            get
            {
                return new DataAccess.Components.PURCHASE_ORDERDAO();
            }
        }
        #endregion        
    }
}
	