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
    public class FIVE_DIMENSIONService : Service.Framework.AbstractService
    {
        #region Constructor
        public FIVE_DIMENSIONService()
        {
        }
        #endregion

        #region Overridden Properties
        public override AbstractDAO dao
        {
            get
            {
                return new DataAccess.Components.FIVE_DIMENSIONDAO();
            }
        }
        #endregion        
    }
}
	