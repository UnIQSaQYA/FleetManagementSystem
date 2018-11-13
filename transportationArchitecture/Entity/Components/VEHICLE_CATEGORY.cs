using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class VEHICLE_CATEGORY : Entity.Framework.EntityBase
    {
		private string _pK_ID;
        private string _vEHICLECATEGORY;

        public string VEHICLECATEGORY
        {
            get { return _vEHICLECATEGORY; }
            set { _vEHICLECATEGORY = value; }
        }
	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		
		
		#region Methods

        public VEHICLE_CATEGORY()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	