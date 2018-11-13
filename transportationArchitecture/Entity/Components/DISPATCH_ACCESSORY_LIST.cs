using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class DISPATCH_ACCESSORY_LIST : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _vEHICLE_DISPATCH_ID;
		private string _aCCESSORY;
	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		public string VEHICLE_DISPATCH_ID
		{
			get { return _vEHICLE_DISPATCH_ID; }
			set { _vEHICLE_DISPATCH_ID = value; }
		}
	
		public string ACCESSORY
		{
			get { return _aCCESSORY; }
			set { _aCCESSORY = value; }
		}
		
		#region Methods

        public DISPATCH_ACCESSORY_LIST()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	