using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class VEHICLE_TYPE : Entity.Framework.EntityBase
    {
        private string _pK_ID;
        private string _vEHICLETYPE;
        private string _vEHICLE_CATEGORY_ID;


        public string VEHICLETYPE
        {
            get { return _vEHICLETYPE; }
            set { _vEHICLETYPE = value; }
        }

        public string PK_ID
        {
            get { return _pK_ID; }
            set { _pK_ID = value; }
        }


        public string VEHICLE_CATEGORY_ID
        {
            get { return _vEHICLE_CATEGORY_ID; }
            set { _vEHICLE_CATEGORY_ID = value; }
        }
	
		
		#region Methods

        public VEHICLE_TYPE()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	