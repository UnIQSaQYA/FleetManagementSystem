using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class CAR_RADIO_HARDWARE : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _vEHICLE_ISSUE_ID;
		private string _uHF_VHF_SNO;
		private string _vERIFIED_BY;
	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		public string VEHICLE_ISSUE_ID
		{
			get { return _vEHICLE_ISSUE_ID; }
			set { _vEHICLE_ISSUE_ID = value; }
		}
	
		public string UHF_VHF_SNO
		{
			get { return _uHF_VHF_SNO; }
			set { _uHF_VHF_SNO = value; }
		}
	
		public string VERIFIED_BY
		{
			get { return _vERIFIED_BY; }
			set { _vERIFIED_BY = value; }
		}
		
		#region Methods

        public CAR_RADIO_HARDWARE()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	