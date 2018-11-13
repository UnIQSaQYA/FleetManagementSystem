using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class VEHICLE_ACCESSORIES : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _vEHICLE_ID;
		private string _aCCESSORIES_ID;
	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		public string VEHICLE_ID
		{
			get { return _vEHICLE_ID; }
			set { _vEHICLE_ID = value; }
		}
	
		public string ACCESSORIES_ID
		{
			get { return _aCCESSORIES_ID; }
			set { _aCCESSORIES_ID = value; }
		}
		
		#region Methods

        public VEHICLE_ACCESSORIES()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	