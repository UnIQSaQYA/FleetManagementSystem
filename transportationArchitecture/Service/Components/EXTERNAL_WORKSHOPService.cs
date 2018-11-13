using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DataAccess.Components;
using DataAccess.Framework;
using DataHelper.Framework;
using Entity.Components;
using Entity.Framework;
using Service.Framework;

namespace Service.Components
{
    public class EXTERNAL_WORKSHOPService : Service.Framework.AbstractService
    {
        #region Constructor
        public EXTERNAL_WORKSHOPService()
        {
        }
        #endregion

        #region Overridden Properties
        public override AbstractDAO dao
        {
            get
            {
                return new DataAccess.Components.EXTERNAL_WORKSHOPDAO();
            }
        }
        #endregion
    }
}
