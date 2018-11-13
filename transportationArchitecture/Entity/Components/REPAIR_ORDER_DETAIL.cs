using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class REPAIR_ORDER_DETAIL : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _rEPAIR_ORDER_ID;
		private string _sNO;
		private string _pARTICULAR;
		private string _qTY;
		private string _uNIT;
		private string _rATE;
		private string _aMOUNT;
		private string _rEMARKS;
        private string _pARTICULAR_TYPE;

        public string PARTICULAR_TYPE
        {
            get { return _pARTICULAR_TYPE; }
            set { _pARTICULAR_TYPE = value; }
        }

		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		public string REPAIR_ORDER_ID
		{
			get { return _rEPAIR_ORDER_ID; }
			set { _rEPAIR_ORDER_ID = value; }
		}
	
		public string SNO
		{
			get { return _sNO; }
			set { _sNO = value; }
		}
	
		public string PARTICULAR
		{
			get { return _pARTICULAR; }
			set { _pARTICULAR = value; }
		}
	
		public string QTY
		{
			get { return _qTY; }
			set { _qTY = value; }
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
	
		public string AMOUNT
		{
			get { return _aMOUNT; }
			set { _aMOUNT = value; }
		}
	
		public string REMARKS
		{
			get { return _rEMARKS; }
			set { _rEMARKS = value; }
		}
		
		#region Methods

        public REPAIR_ORDER_DETAIL()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	