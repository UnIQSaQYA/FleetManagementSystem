using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class M_COMPLITION_DETAIL : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _m_COMPLITION_ID;
		private string _sNO;
		private string _pARTS_LABOUR;
		private string _pARTS_LABOUR_ID;
		private string _qTY;
		private string _rATE_PER_UNIT;
		private string _tOTAL_COST;
		private string _sUPPLIER_ID;
		private string _sUPPLY_DATE;
		private string _iNVOICE_NO;
		private string _rEMARKS;
	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		public string M_COMPLITION_ID
		{
			get { return _m_COMPLITION_ID; }
			set { _m_COMPLITION_ID = value; }
		}
	
		public string SNO
		{
			get { return _sNO; }
			set { _sNO = value; }
		}
	
		public string PARTS_LABOUR
		{
			get { return _pARTS_LABOUR; }
			set { _pARTS_LABOUR = value; }
		}
	
		public string PARTS_LABOUR_ID
		{
			get { return _pARTS_LABOUR_ID; }
			set { _pARTS_LABOUR_ID = value; }
		}
	
		public string QTY
		{
			get { return _qTY; }
			set { _qTY = value; }
		}
	
		public string RATE_PER_UNIT
		{
			get { return _rATE_PER_UNIT; }
			set { _rATE_PER_UNIT = value; }
		}
	
		public string TOTAL_COST
		{
			get { return _tOTAL_COST; }
			set { _tOTAL_COST = value; }
		}
	
		public string SUPPLIER_ID
		{
			get { return _sUPPLIER_ID; }
			set { _sUPPLIER_ID = value; }
		}
	
		public string SUPPLY_DATE
		{
			get { return _sUPPLY_DATE; }
			set { _sUPPLY_DATE = value; }
		}
	
		public string INVOICE_NO
		{
			get { return _iNVOICE_NO; }
			set { _iNVOICE_NO = value; }
		}
	
		public string REMARKS
		{
			get { return _rEMARKS; }
			set { _rEMARKS = value; }
		}
		
		#region Methods

        public M_COMPLITION_DETAIL()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	