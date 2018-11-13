using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class VEHICLE_ISSUE : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _vEHICLE_ISSUE_CODE;
		private string _iSSUE_DAY;
		private string _iSSUE_MONTH;
		private string _iSSUE_YEAR;
		private string _iSSUE_DATE;
		private string _iSSUE_FISCAL_YEAR;
		private string _vEHICLE_ID;
		private string _oDOMETER;
		private string _dAMAGE_DESCRIPTION;
		private string _iSSUER_ID;
		private string _eNTRY_DAY;
		private string _eNTRY_MONTH;
		private string _eNTRY_YEAR;
		private string _eNTRY_DATE;
		private string _rECEIVER_ID;
		private string _rECEIVE_DAY;
		private string _rECEIVE_MONTH;
		private string _rECEIVE_YEAR;
		private string _rECEIVER_DATE;
		private string _vEHICLE_CHECK_BY;
		private string _rECEIVER_ID_COPY;
	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		public string VEHICLE_ISSUE_CODE
		{
			get { return _vEHICLE_ISSUE_CODE; }
			set { _vEHICLE_ISSUE_CODE = value; }
		}
	
		public string ISSUE_DAY
		{
			get { return _iSSUE_DAY; }
			set { _iSSUE_DAY = value; }
		}
	
		public string ISSUE_MONTH
		{
			get { return _iSSUE_MONTH; }
			set { _iSSUE_MONTH = value; }
		}
	
		public string ISSUE_YEAR
		{
			get { return _iSSUE_YEAR; }
			set { _iSSUE_YEAR = value; }
		}
	
		public string ISSUE_DATE
		{
			get { return _iSSUE_DATE; }
			set { _iSSUE_DATE = value; }
		}
	
		public string ISSUE_FISCAL_YEAR
		{
			get { return _iSSUE_FISCAL_YEAR; }
			set { _iSSUE_FISCAL_YEAR = value; }
		}
	
		public string VEHICLE_ID
		{
			get { return _vEHICLE_ID; }
			set { _vEHICLE_ID = value; }
		}
	
		public string ODOMETER
		{
			get { return _oDOMETER; }
			set { _oDOMETER = value; }
		}
	
		public string DAMAGE_DESCRIPTION
		{
			get { return _dAMAGE_DESCRIPTION; }
			set { _dAMAGE_DESCRIPTION = value; }
		}
	
		public string ISSUER_ID
		{
			get { return _iSSUER_ID; }
			set { _iSSUER_ID = value; }
		}
	
		public string ENTRY_DAY
		{
			get { return _eNTRY_DAY; }
			set { _eNTRY_DAY = value; }
		}
	
		public string ENTRY_MONTH
		{
			get { return _eNTRY_MONTH; }
			set { _eNTRY_MONTH = value; }
		}
	
		public string ENTRY_YEAR
		{
			get { return _eNTRY_YEAR; }
			set { _eNTRY_YEAR = value; }
		}
	
		public string ENTRY_DATE
		{
			get { return _eNTRY_DATE; }
			set { _eNTRY_DATE = value; }
		}
	
		public string RECEIVER_ID
		{
			get { return _rECEIVER_ID; }
			set { _rECEIVER_ID = value; }
		}
	
		public string RECEIVE_DAY
		{
			get { return _rECEIVE_DAY; }
			set { _rECEIVE_DAY = value; }
		}
	
		public string RECEIVE_MONTH
		{
			get { return _rECEIVE_MONTH; }
			set { _rECEIVE_MONTH = value; }
		}
	
		public string RECEIVE_YEAR
		{
			get { return _rECEIVE_YEAR; }
			set { _rECEIVE_YEAR = value; }
		}
	
		public string RECEIVER_DATE
		{
			get { return _rECEIVER_DATE; }
			set { _rECEIVER_DATE = value; }
		}
	
		public string VEHICLE_CHECK_BY
		{
			get { return _vEHICLE_CHECK_BY; }
			set { _vEHICLE_CHECK_BY = value; }
		}
	
		public string RECEIVER_ID_COPY
		{
			get { return _rECEIVER_ID_COPY; }
			set { _rECEIVER_ID_COPY = value; }
		}
		
		#region Methods

        public VEHICLE_ISSUE()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	