using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class M_EXPECTED_PARTS_LABOUR : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _jOB_CARD_ID;
		private string _sNO;
		private string _pARTS_LABOUR;
		private string _pARTS_LABOUR_ID;
		private string _rEQUIRED_QTY;
		private string _eSTIMATED_RATE;
		private string _rEMARKS;
	
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
	
		public string REQUIRED_QTY
		{
			get { return _rEQUIRED_QTY; }
			set { _rEQUIRED_QTY = value; }
		}
	
		public string ESTIMATED_RATE
		{
			get { return _eSTIMATED_RATE; }
			set { _eSTIMATED_RATE = value; }
		}
	
		public string REMARKS
		{
			get { return _rEMARKS; }
			set { _rEMARKS = value; }
		}
		
		#region Methods

        public M_EXPECTED_PARTS_LABOUR()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	