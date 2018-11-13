using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class PURCHASE_ORDER_DETAIL : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _pURCHASE_ORDER_ID;
		private string _sNO;
		private string _pRODUCT_ID;
		private string _qUANTITY;
		private string _uNIT;
		private string _rATE;
		private string _tOTAL;
		private string _rEMARKS;
	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		public string PURCHASE_ORDER_ID
		{
			get { return _pURCHASE_ORDER_ID; }
			set { _pURCHASE_ORDER_ID = value; }
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
	
		public string QUANTITY
		{
			get { return _qUANTITY; }
			set { _qUANTITY = value; }
		}
	
		public string UNIT
		{
			get { return _uNIT; }
			set { _uNIT = value; }
		}
	
		public string RATE
		{
			get { return _rATE; }
			set { _rATE = value; }
		}
	
		public string TOTAL
		{
			get { return _tOTAL; }
			set { _tOTAL = value; }
		}
	
		public string REMARKS
		{
			get { return _rEMARKS; }
			set { _rEMARKS = value; }
		}
		
		#region Methods

        public PURCHASE_ORDER_DETAIL()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	