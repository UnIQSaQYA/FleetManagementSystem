using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class PRODUCT_DEMAND_DETAIL : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _pRODUCT_DEMAND_ID;
		private string _sNO;
		private string _pRODUCT_ID;
		private string _rEQUEST_QTY;
		private string _uNIT;
		private string _iSSUE_QTY;
		private string _lEDGER_PAGE_NO;
		private string _rEMARKS;
		private string _aPPROVE_QTY;
	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		public string PRODUCT_DEMAND_ID
		{
			get { return _pRODUCT_DEMAND_ID; }
			set { _pRODUCT_DEMAND_ID = value; }
		}
	
		public string SNO
		{
			get { return _sNO; }
			set { _sNO = value; }
		}
	
		public string PRODUCT_ID
		{
			get { return _pRODUCT_ID; }
			set { _pRODUCT_ID = value; }
		}
	
		public string REQUEST_QTY
		{
			get { return _rEQUEST_QTY; }
			set { _rEQUEST_QTY = value; }
		}
	
		public string UNIT
		{
			get { return _uNIT; }
			set { _uNIT = value; }
		}
	
		public string ISSUE_QTY
		{
			get { return _iSSUE_QTY; }
			set { _iSSUE_QTY = value; }
		}
	
		public string LEDGER_PAGE_NO
		{
			get { return _lEDGER_PAGE_NO; }
			set { _lEDGER_PAGE_NO = value; }
		}
	
		public string REMARKS
		{
			get { return _rEMARKS; }
			set { _rEMARKS = value; }
		}
	
		public string APPROVE_QTY
		{
			get { return _aPPROVE_QTY; }
			set { _aPPROVE_QTY = value; }
		}
		
		#region Methods

        public PRODUCT_DEMAND_DETAIL()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	