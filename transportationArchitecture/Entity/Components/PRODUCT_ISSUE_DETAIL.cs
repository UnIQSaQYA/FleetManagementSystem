using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class PRODUCT_ISSUE_DETAIL : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _pRODUCT_ISSUE_ID;
		private string _sNO;
		private string _lFONO;
		private string _pRODUCT_ID;
		private string _qTY;
		private string _uNIT;
		private string _iNITIAL_RECEIVED_DATE;
		private string _rEMARKS;
        private string _bATCH_NO;
        private string _oFFICE_CODE;

        public string OFFICE_CODE
        {
            get { return _oFFICE_CODE; }
            set { _oFFICE_CODE = value; }
        }

        public string BATCH_NO
        {
            get { return _bATCH_NO; }
            set { _bATCH_NO = value; }
        }

		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		public string PRODUCT_ISSUE_ID
		{
			get { return _pRODUCT_ISSUE_ID; }
			set { _pRODUCT_ISSUE_ID = value; }
		}
	
		public string SNO
		{
			get { return _sNO; }
			set { _sNO = value; }
		}
	
		public string LFONO
		{
			get { return _lFONO; }
			set { _lFONO = value; }
		}
	
		public string PRODUCT_ID
		{
			get { return _pRODUCT_ID; }
			set { _pRODUCT_ID = value; }
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
	
		public string INITIAL_RECEIVED_DATE
		{
			get { return _iNITIAL_RECEIVED_DATE; }
			set { _iNITIAL_RECEIVED_DATE = value; }
		}
	
		public string REMARKS
		{
			get { return _rEMARKS; }
			set { _rEMARKS = value; }
		}
		
		#region Methods

        public PRODUCT_ISSUE_DETAIL()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	