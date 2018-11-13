using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class VEHICLE_USER : Entity.Framework.EntityBase
    {
		private string _pK_ID;
        private string _vEHICLEUSER;

        public string VEHICLEUSER
        {
            get { return _vEHICLEUSER; }
            set { _vEHICLEUSER = value; }
        }
	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
	
		
		#region Methods

        public VEHICLE_USER()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	