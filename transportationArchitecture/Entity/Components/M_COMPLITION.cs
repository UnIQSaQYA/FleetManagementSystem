using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class M_COMPLITION : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _jOB_CARD_ID;
		private string _c_DATE;
		private string _c_DAY;
		private string _c_MONTH;
		private string _c_YEAR;
		private string _c_FY;
		private string _sUPERVISOR_ID;
		private string _dEPARTMENTHEAD_ID;
		private string _d_DATE;
	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		public string JOB_CARD_ID
		{
			get { return _jOB_CARD_ID; }
			set { _jOB_CARD_ID = value; }
		}
	
		public string C_DATE
		{
			get { return _c_DATE; }
			set { _c_DATE = value; }
		}
	
		public string C_DAY
		{
			get { return _c_DAY; }
			set { _c_DAY = value; }
		}
	
		public string C_MONTH
		{
			get { return _c_MONTH; }
			set { _c_MONTH = value; }
		}
	
		public string C_YEAR
		{
			get { return _c_YEAR; }
			set { _c_YEAR = value; }
		}
	
		public string C_FY
		{
			get { return _c_FY; }
			set { _c_FY = value; }
		}
	
		public string SUPERVISOR_ID
		{
			get { return _sUPERVISOR_ID; }
			set { _sUPERVISOR_ID = value; }
		}
	
		public string DEPARTMENTHEAD_ID
		{
			get { return _dEPARTMENTHEAD_ID; }
			set { _dEPARTMENTHEAD_ID = value; }
		}
	
		public string D_DATE
		{
			get { return _d_DATE; }
			set { _d_DATE = value; }
		}
		
		#region Methods

        public M_COMPLITION()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	