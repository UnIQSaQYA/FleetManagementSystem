using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class VECHICLE_ACCIDENT : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _vEHICLE_ID;
		private string _aCCIDENT_TYPE_ID;
		private string _aCCIDENT_DAY;
		private string _aCCIDENT_MONTH;
		private string _aCCIDENT_YEAR;
		private string _aCCIDENT_PLACE;
		private string _aCCIDENT_DETAIL;
		private string _dRIVER_ID;
        private string _oFFICE_CODE;
        private string _aCCIDENT_NO;
        private string _aCCIDENT_FISCAL_YEAR;

        public string ACCIDENT_FISCAL_YEAR
        {
            get { return _aCCIDENT_FISCAL_YEAR; }
            set { _aCCIDENT_FISCAL_YEAR = value; }
        }

        public string ACCIDENT_NO
        {
            get { return _aCCIDENT_NO; }
            set { _aCCIDENT_NO = value; }
        }

        public string OFFICE_CODE
        {
            get { return _oFFICE_CODE; }
            set { _oFFICE_CODE = value; }
        }

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
	
		public string ACCIDENT_TYPE_ID
		{
			get { return _aCCIDENT_TYPE_ID; }
			set { _aCCIDENT_TYPE_ID = value; }
		}
	
		public string ACCIDENT_DAY
		{
			get { return _aCCIDENT_DAY; }
			set { _aCCIDENT_DAY = value; }
		}
	
		public string ACCIDENT_MONTH
		{
			get { return _aCCIDENT_MONTH; }
			set { _aCCIDENT_MONTH = value; }
		}
	
		public string ACCIDENT_YEAR
		{
			get { return _aCCIDENT_YEAR; }
			set { _aCCIDENT_YEAR = value; }
		}
	
		public string ACCIDENT_PLACE
		{
			get { return _aCCIDENT_PLACE; }
			set { _aCCIDENT_PLACE = value; }
		}
	
		public string ACCIDENT_DETAIL
		{
			get { return _aCCIDENT_DETAIL; }
			set { _aCCIDENT_DETAIL = value; }
		}
	
		public string DRIVER_ID
		{
			get { return _dRIVER_ID; }
			set { _dRIVER_ID = value; }
		}
		
		#region Methods

        public VECHICLE_ACCIDENT()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	