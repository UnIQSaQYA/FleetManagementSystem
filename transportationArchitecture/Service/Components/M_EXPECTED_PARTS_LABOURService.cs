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
    public class M_EXPECTED_PARTS_LABOURService : Service.Framework.AbstractService
    {
        #region Constructor
        public M_EXPECTED_PARTS_LABOURService()
        {
        }
        #endregion

        #region Overridden Properties
        public override AbstractDAO dao
        {
            get
            {
                return new DataAccess.Components.M_EXPECTED_PARTS_LABOURDAO();
            }
        }
        #endregion        
    }
}
	