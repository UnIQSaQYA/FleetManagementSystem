using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class VEHICLE_ISSUE_RETURN : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _vEHICLE_ISSUE_RETURN_CODE;
		private string _vEHICLE_ID;
		private string _dAMAGE_DESCRIPTION;
		private string _rETURN_BY_ID;
		private string _rETURN_DAY;
		private string _rETURN_MONTH;
		private string _rETURN_YEAR;
		private string _rETURN_DATE;
		private string _rECEIVER_ID;
		private string _rECEIVE_DAY;
		private string _rECEIVE_MONTH;
		private string _rECEIVE_YEAR;
		private string _rECEIVER_DATE;
		private string _rECEIVER_ID_COPY;
	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		public string VEHICLE_ISSUE_RETURN_CODE
		{
			get { return _vEHICLE_ISSUE_RETURN_CODE; }
			set { _vEHICLE_ISSUE_RETURN_CODE = value; }
		}
	
		public string VEHICLE_ID
		{
			get { return _vEHICLE_ID; }
			set { _vEHICLE_ID = value; }
		}
	
		public string DAMAGE_DESCRIPTION
		{
			get { return _dAMAGE_DESCRIPTION; }
			set { _dAMAGE_DESCRIPTION = value; }
		}
	
		public string RETURN_BY_ID
		{
			get { return _rETURN_BY_ID; }
			set { _rETURN_BY_ID = value; }
		}
	
		public string RETURN_DAY
		{
			get { return _rETURN_DAY; }
			set { _rETURN_DAY = value; }
		}
	
		public string RETURN_MONTH
		{
			get { return _rETURN_MONTH; }
			set { _rETURN_MONTH = value; }
		}
	
		public string RETURN_YEAR
		{
			get { return _rETURN_YEAR; }
			set { _rETURN_YEAR = value; }
		}
	
		public string RETURN_DATE
		{
			get { return _rETURN_DATE; }
			set { _rETURN_DATE = value; }
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
	
		public string RECEIVER_ID_COPY
		{
			get { return _rECEIVER_ID_COPY; }
			set { _rECEIVER_ID_COPY = value; }
		}
		
		#region Methods

        public VEHICLE_ISSUE_RETURN()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	