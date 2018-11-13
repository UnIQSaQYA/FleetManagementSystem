using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class M_JOB_CARD : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _jOB_NUMBER;
		private string _jOB_DAY;
		private string _jOB_MONTH;
		private string _jOB_YEAR;
		private string _jOB_DATE;
		private string _jOB_FY;
		private string _vECCHILE_REG_NO;
		private string _pRIORITY;
		private string _oDOMETER;
		private string _dRIVER_ID;
		private string _mECHANICS_ID;
		private string _vECHICLE_USER;
		private string _mAINTAINANCE_SUPERVISOR_ID;
		private string _rEFER_BY_ID;
		private string _aPPROVE_BY_ID;
		private string _oFFICE;
		private string _bASE_SATATION;
		private string _mAINTAINANCE;
		private string _sERVICING;
	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		public string JOB_NUMBER
		{
			get { return _jOB_NUMBER; }
			set { _jOB_NUMBER = value; }
		}
	
		public string JOB_DAY
		{
			get { return _jOB_DAY; }
			set { _jOB_DAY = value; }
		}
	
		public string JOB_MONTH
		{
			get { return _jOB_MONTH; }
			set { _jOB_MONTH = value; }
		}
	
		public string JOB_YEAR
		{
			get { return _jOB_YEAR; }
			set { _jOB_YEAR = value; }
		}
	
		public string JOB_DATE
		{
			get { return _jOB_DATE; }
			set { _jOB_DATE = value; }
		}
	
		public string JOB_FY
		{
			get { return _jOB_FY; }
			set { _jOB_FY = value; }
		}
	
		public string VECCHILE_REG_NO
		{
			get { return _vECCHILE_REG_NO; }
			set { _vECCHILE_REG_NO = value; }
		}
	
		public string PRIORITY
		{
			get { return _pRIORITY; }
			set { _pRIORITY = value; }
		}
	
		public string ODOMETER
		{
			get { return _oDOMETER; }
			set { _oDOMETER = value; }
		}
	
		public string DRIVER_ID
		{
			get { return _dRIVER_ID; }
			set { _dRIVER_ID = value; }
		}
	
		public string MECHANICS_ID
		{
			get { return _mECHANICS_ID; }
			set { _mECHANICS_ID = value; }
		}
	
		public string VECHICLE_USER
		{
			get { return _vECHICLE_USER; }
			set { _vECHICLE_USER = value; }
		}
	
		public string MAINTAINANCE_SUPERVISOR_ID
		{
			get { return _mAINTAINANCE_SUPERVISOR_ID; }
			set { _mAINTAINANCE_SUPERVISOR_ID = value; }
		}
	
		public string REFER_BY_ID
		{
			get { return _rEFER_BY_ID; }
			set { _rEFER_BY_ID = value; }
		}
	
		public string APPROVE_BY_ID
		{
			get { return _aPPROVE_BY_ID; }
			set { _aPPROVE_BY_ID = value; }
		}
	
		public string OFFICE
		{
			get { return _oFFICE; }
			set { _oFFICE = value; }
		}
	
		public string BASE_SATATION
		{
			get { return _bASE_SATATION; }
			set { _bASE_SATATION = value; }
		}
	
		public string MAINTAINANCE
		{
			get { return _mAINTAINANCE; }
			set { _mAINTAINANCE = value; }
		}
	
		public string SERVICING
		{
			get { return _sERVICING; }
			set { _sERVICING = value; }
		}
		
		#region Methods

        public M_JOB_CARD()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	