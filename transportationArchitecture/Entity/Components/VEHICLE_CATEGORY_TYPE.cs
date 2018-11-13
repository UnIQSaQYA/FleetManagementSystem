using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity.Components
{
    public class VEHICLE_CATEGORY_TYPE: Entity.Framework.EntityBase
    {
        private string _pK_ID;
        private string _vEHICLE_CAT_ID;
        private string _vEHICLE_TYPE_ID;
	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
        public string VEHICLE_CAT_ID
        {
          get { return _vEHICLE_CAT_ID; }
          set { _vEHICLE_CAT_ID = value; }
        }
        public string VEHICLE_TYPE_ID
        {
            get { return _vEHICLE_TYPE_ID; }
            set { _vEHICLE_TYPE_ID = value; }
        }
	
		
		#region Methods

        public  VEHICLE_CATEGORY_TYPE()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
