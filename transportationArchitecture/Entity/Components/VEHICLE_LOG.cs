using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class VEHICLE_LOG : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _vEHICLE_REG_NO;
		private string _pREVIOUS_VEHICLE_REG_NO;
		private string _lOG_DAY;
		private string _lOG_MONTH;
		private string _lOG_YEAR;
		private string _lOG_DATE;
        private string _dESTINATION_FROM;

        public string DESTINATION_FROM
        {
            get { return _dESTINATION_FROM; }
            set { _dESTINATION_FROM = value; }
        }
        private string _dESTINATION_TO;

        public string DESTINATION_TO
        {
            get { return _dESTINATION_TO; }
            set { _dESTINATION_TO = value; }
        }
		private string _rEASON_FOR_MOVEMENT;
		private string _oRDER_BY;
		private string _iSSUE_ODOMETER;
		private string _rECEIVE_ODOMETER;
		private string _rECEIVE_DAY;
		private string _rECEIVE_MONTH;
		private string _rECEIVE_YEAR;
		private string _rECEIVE_DATE;
		private string _dRIVER_ID;
		private string _dRIVER_MOBILE;
		private string _vEHICLE_USER_ID;
	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		public string VEHICLE_REG_NO
		{
			get { return _vEHICLE_REG_NO; }
			set { _vEHICLE_REG_NO = value; }
		}
	
		public string PREVIOUS_VEHICLE_REG_NO
		{
			get { return _pREVIOUS_VEHICLE_REG_NO; }
			set { _pREVIOUS_VEHICLE_REG_NO = value; }
		}
	
		public string LOG_DAY
		{
			get { return _lOG_DAY; }
			set { _lOG_DAY = value; }
		}
	
		public string LOG_MONTH
		{
			get { return _lOG_MONTH; }
			set { _lOG_MONTH = value; }
		}
	
		public string LOG_YEAR
		{
			get { return _lOG_YEAR; }
			set { _lOG_YEAR = value; }
		}
	
		public string LOG_DATE
		{
			get { return _lOG_DATE; }
			set { _lOG_DATE = value; }
		}
	
	
		public string REASON_FOR_MOVEMENT
		{
			get { return _rEASON_FOR_MOVEMENT; }
			set { _rEASON_FOR_MOVEMENT = value; }
		}
	
		public string ORDER_BY
		{
			get { return _oRDER_BY; }
			set { _oRDER_BY = value; }
		}
	
		public string ISSUE_ODOMETER
		{
			get { return _iSSUE_ODOMETER; }
			set { _iSSUE_ODOMETER = value; }
		}
	
		public string RECEIVE_ODOMETER
		{
			get { return _rECEIVE_ODOMETER; }
			set { _rECEIVE_ODOMETER = value; }
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
	
		public string RECEIVE_DATE
		{
			get { return _rECEIVE_DATE; }
			set { _rECEIVE_DATE = value; }
		}
	
		public string DRIVER_ID
		{
			get { return _dRIVER_ID; }
			set { _dRIVER_ID = value; }
		}
	
		public string DRIVER_MOBILE
		{
			get { return _dRIVER_MOBILE; }
			set { _dRIVER_MOBILE = value; }
		}
	
		public string VEHICLE_USER_ID
		{
			get { return _vEHICLE_USER_ID; }
			set { _vEHICLE_USER_ID = value; }
		}
		
		#region Methods

        public VEHICLE_LOG()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	