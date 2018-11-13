using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class ACCESSORIES : Entity.Framework.EntityBase
    {
		private string _pK_ID;
        private string _vEHICLE_TYPE_ID;

        
        private string _aCCESSORIESS;

        public string ACCESSORIESS
        {
            get { return _aCCESSORIESS; }
            set { _aCCESSORIESS = value; }
        }
	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
        public string VEHICLE_TYPE_ID
        {
            get { return _vEHICLE_TYPE_ID; }
            set { _vEHICLE_TYPE_ID = value; }
        }
	
	
	

		
		#region Methods

        public ACCESSORIES()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	