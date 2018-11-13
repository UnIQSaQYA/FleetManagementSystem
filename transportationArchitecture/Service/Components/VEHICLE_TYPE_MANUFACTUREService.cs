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
    public class VEHICLE_TYPE_MANUFACTUREService: Service.Framework.AbstractService
    {
        #region Constructor
        public VEHICLE_TYPE_MANUFACTUREService()
        {
        }
        #endregion

        #region Overridden Properties
        public override AbstractDAO dao
        {
            get
            {
                return new DataAccess.Components.VEHICLE_TYPE_MANUFACTUREDAO();
            }
        }
        #endregion        
    }
}
