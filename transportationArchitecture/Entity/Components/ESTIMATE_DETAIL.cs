using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class ESTIMATE_DETAIL : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _eSTIMATE_MASTER_ID;
		private string _sNO;
		private string _pARTS_LABOUR;
		private string _pARTS_LABOUR_ID;
		private string _qTY;
		private string _rATE;
		private string _tOTAL_COST;
	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		public string ESTIMATE_MASTER_ID
		{
			get { return _eSTIMATE_MASTER_ID; }
			set { _eSTIMATE_MASTER_ID = value; }
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
	
		public string RATE
		{
			get { return _rATE; }
			set { _rATE = value; }
		}
	
		public string TOTAL_COST
		{
			get { return _tOTAL_COST; }
			set { _tOTAL_COST = value; }
		}
		
		#region Methods

        public ESTIMATE_DETAIL()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	