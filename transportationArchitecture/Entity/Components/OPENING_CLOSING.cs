using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class OPENING_CLOSING : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _fISCAL_YEAR;
		private string _pRODUCT_ID;
		private string _oPENING_QTY;
		private string _pURCHASE_QTY;
		private string _rETURN_QTY;
		private string _aDJUSTED_QTY;
		private string _iSSUE_QTY;
		private string _cLOSING_QTY;
		private string _uNIT;
        private string _bATCH;
        private string _eXPIRY_DATE;
        private string _rATE;

        public string RATE
        {
            get { return _rATE; }
            set { _rATE = value; }
        }
        
        public string EXPIRY_DATE
        {
            get { return _eXPIRY_DATE; }
            set { _eXPIRY_DATE = value; }
        }
       
        public string BATCH
        {
            get { return _bATCH; }
            set { _bATCH = value; }
        }

		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		public string FISCAL_YEAR
		{
			get { return _fISCAL_YEAR; }
			set { _fISCAL_YEAR = value; }
		}
	
		public string PRODUCT_ID
		{
			get { return _pRODUCT_ID; }
			set { _pRODUCT_ID = value; }
		}
	
		public string OPENING_QTY
		{
			get { return _oPENING_QTY; }
			set { _oPENING_QTY = value; }
		}
	
		public string PURCHASE_QTY
		{
			get { return _pURCHASE_QTY; }
			set { _pURCHASE_QTY = value; }
		}
	
		public string RETURN_QTY
		{
			get { return _rETURN_QTY; }
			set { _rETURN_QTY = value; }
		}
	
		public string ADJUSTED_QTY
		{
			get { return _aDJUSTED_QTY; }
			set { _aDJUSTED_QTY = value; }
		}
	
		public string ISSUE_QTY
		{
			get { return _iSSUE_QTY; }
			set { _iSSUE_QTY = value; }
		}
	
		public string CLOSING_QTY
		{
			get { return _cLOSING_QTY; }
			set { _cLOSING_QTY = value; }
		}
	
		public string UNIT
		{
			get { return _uNIT; }
			set { _uNIT = value; }
		}
		
		#region Methods

        public OPENING_CLOSING()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	