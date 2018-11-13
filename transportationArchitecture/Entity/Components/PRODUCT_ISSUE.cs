using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class PRODUCT_ISSUE : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _iSSUE_NO;
		private string _iSSUE_DAY;
		private string _iSSUE_MONTH;
		private string _iSSUE_YEAR;
		private string _iSSUE_DATE;
		private string _iSSUE_FISCALYEAR;
		private string _iNTERNAL_EXTERNAL;
		private string _iSSUE_TO_OFFICE_NAME;
		private string _dECISION_DAY;
		private string _dECISION_MONTH;
		private string _dECISION_YEAR;
		private string _dECISION_DATE;
		private string _dELIVERY_OFFICE;
		private string _dELIVERY_BY;
		private string _dELIVERY_DESIGNATION;
		private string _dELIVERY_REC_THROUGH;
		private string _rECEIVED_BY;
		private string _rECEIVED_BY_DESIGNATION;
		private string _rECEIVED_DATE;
        private string _pRODUCT_DEMAND_NO;

        public string PRODUCT_DEMAND_NO
        {
            get { return _pRODUCT_DEMAND_NO; }
            set { _pRODUCT_DEMAND_NO = value; }
        }
	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		public string ISSUE_NO
		{
			get { return _iSSUE_NO; }
			set { _iSSUE_NO = value; }
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
	
		public string ISSUE_FISCALYEAR
		{
			get { return _iSSUE_FISCALYEAR; }
			set { _iSSUE_FISCALYEAR = value; }
		}
	
		public string INTERNAL_EXTERNAL
		{
			get { return _iNTERNAL_EXTERNAL; }
			set { _iNTERNAL_EXTERNAL = value; }
		}
	
		public string ISSUE_TO_OFFICE_NAME
		{
			get { return _iSSUE_TO_OFFICE_NAME; }
			set { _iSSUE_TO_OFFICE_NAME = value; }
		}
	
		public string DECISION_DAY
		{
			get { return _dECISION_DAY; }
			set { _dECISION_DAY = value; }
		}
	
		public string DECISION_MONTH
		{
			get { return _dECISION_MONTH; }
			set { _dECISION_MONTH = value; }
		}
	
		public string DECISION_YEAR
		{
			get { return _dECISION_YEAR; }
			set { _dECISION_YEAR = value; }
		}
	
		public string DECISION_DATE
		{
			get { return _dECISION_DATE; }
			set { _dECISION_DATE = value; }
		}
	
		public string DELIVERY_OFFICE
		{
			get { return _dELIVERY_OFFICE; }
			set { _dELIVERY_OFFICE = value; }
		}
	
		public string DELIVERY_BY
		{
			get { return _dELIVERY_BY; }
			set { _dELIVERY_BY = value; }
		}
	
		public string DELIVERY_DESIGNATION
		{
			get { return _dELIVERY_DESIGNATION; }
			set { _dELIVERY_DESIGNATION = value; }
		}
	
		public string DELIVERY_REC_THROUGH
		{
			get { return _dELIVERY_REC_THROUGH; }
			set { _dELIVERY_REC_THROUGH = value; }
		}
	
		public string RECEIVED_BY
		{
			get { return _rECEIVED_BY; }
			set { _rECEIVED_BY = value; }
		}
	
		public string RECEIVED_BY_DESIGNATION
		{
			get { return _rECEIVED_BY_DESIGNATION; }
			set { _rECEIVED_BY_DESIGNATION = value; }
		}
	
		public string RECEIVED_DATE
		{
			get { return _rECEIVED_DATE; }
			set { _rECEIVED_DATE = value; }
		}

       
		#region Methods

        public PRODUCT_ISSUE()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	