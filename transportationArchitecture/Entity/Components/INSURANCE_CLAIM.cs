using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class INSURANCE_CLAIM : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _vEHICLE_ACCIDENT_ID;
		private string _rEPORTING_DATE;
		private string _rEPORTING_DAY;
		private string _rEPORTING_MONTH;
		private string _rEPORTING_YEAR;
		private string _iNSURANCE_COMPANY_ID;
		private string _rEPAIRED_SHOP;
		private string _rEPAIRED_DETAIL;
		private string _cLAIMED_COST;
		private string _rEIMBURSED_COST;
		private string _rEIMBURSED_REFERENCE;
	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		public string VEHICLE_ACCIDENT_ID
		{
			get { return _vEHICLE_ACCIDENT_ID; }
			set { _vEHICLE_ACCIDENT_ID = value; }
		}
	
		public string REPORTING_DATE
		{
			get { return _rEPORTING_DATE; }
			set { _rEPORTING_DATE = value; }
		}
	
		public string REPORTING_DAY
		{
			get { return _rEPORTING_DAY; }
			set { _rEPORTING_DAY = value; }
		}
	
		public string REPORTING_MONTH
		{
			get { return _rEPORTING_MONTH; }
			set { _rEPORTING_MONTH = value; }
		}
	
		public string REPORTING_YEAR
		{
			get { return _rEPORTING_YEAR; }
			set { _rEPORTING_YEAR = value; }
		}
	
		public string INSURANCE_COMPANY_ID
		{
			get { return _iNSURANCE_COMPANY_ID; }
			set { _iNSURANCE_COMPANY_ID = value; }
		}
	
		public string REPAIRED_SHOP
		{
			get { return _rEPAIRED_SHOP; }
			set { _rEPAIRED_SHOP = value; }
		}
	
		public string REPAIRED_DETAIL
		{
			get { return _rEPAIRED_DETAIL; }
			set { _rEPAIRED_DETAIL = value; }
		}
	
		public string CLAIMED_COST
		{
			get { return _cLAIMED_COST; }
			set { _cLAIMED_COST = value; }
		}
	
		public string REIMBURSED_COST
		{
			get { return _rEIMBURSED_COST; }
			set { _rEIMBURSED_COST = value; }
		}
	
		public string REIMBURSED_REFERENCE
		{
			get { return _rEIMBURSED_REFERENCE; }
			set { _rEIMBURSED_REFERENCE = value; }
		}
		
		#region Methods

        public INSURANCE_CLAIM()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	