using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class PRODUCT : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _pRODUCT_TYPE_ID;
		private string _pRODUCT_CODE;
		private string _pRODUCT_NAME;
		private string _nATURE_CATEGORY;
		private string _pRICE_CATEGORY;
		private string _uNIT;
		private string _rEORDER_LEVEL;
		private string _mAXIMUM_QTY;
		private string _sTORAGE_DETAIL;
		private string _fORMAT;
		private string _sPECIFICATION;
		private string _sTATUS;
        private string _bUDGET_CODE;
        private string _cLASSIFICATION_CODE;

        public string CLASSIFICATION_CODE
        {
            get { return _cLASSIFICATION_CODE; }
            set { _cLASSIFICATION_CODE = value; }
        }
        public string BUDGET_CODE
        {
            get { return _bUDGET_CODE; }
            set { _bUDGET_CODE = value; }
        }
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		public string PRODUCT_TYPE_ID
		{
			get { return _pRODUCT_TYPE_ID; }
			set { _pRODUCT_TYPE_ID = value; }
		}
	
		public string PRODUCT_CODE
		{
			get { return _pRODUCT_CODE; }
			set { _pRODUCT_CODE = value; }
		}
	
		public string PRODUCT_NAME
		{
			get { return _pRODUCT_NAME; }
			set { _pRODUCT_NAME = value; }
		}
	
		public string NATURE_CATEGORY
		{
			get { return _nATURE_CATEGORY; }
			set { _nATURE_CATEGORY = value; }
		}
	
		public string PRICE_CATEGORY
		{
			get { return _pRICE_CATEGORY; }
			set { _pRICE_CATEGORY = value; }
		}
	
		public string UNIT
		{
			get { return _uNIT; }
			set { _uNIT = value; }
		}
	
		public string REORDER_LEVEL
		{
			get { return _rEORDER_LEVEL; }
			set { _rEORDER_LEVEL = value; }
		}
	
		public string MAXIMUM_QTY
		{
			get { return _mAXIMUM_QTY; }
			set { _mAXIMUM_QTY = value; }
		}
	
		public string STORAGE_DETAIL
		{
			get { return _sTORAGE_DETAIL; }
			set { _sTORAGE_DETAIL = value; }
		}
	
		public string FORMAT
		{
			get { return _fORMAT; }
			set { _fORMAT = value; }
		}
	
		public string SPECIFICATION
		{
			get { return _sPECIFICATION; }
			set { _sPECIFICATION = value; }
		}
	
		public string STATUS
		{
			get { return _sTATUS; }
			set { _sTATUS = value; }
		}
		
		#region Methods

        public PRODUCT()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	