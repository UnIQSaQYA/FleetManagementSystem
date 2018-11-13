using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class PRODUCT_TYPE : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _pRODUCT_CATEGORY_ID;
        private string _pRODUCTTYPE;
        private string _rEMARKS;
        private string _pRODUCT_TYPE_CODE;

       
		
	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		public string PRODUCT_CATEGORY_ID
		{
			get { return _pRODUCT_CATEGORY_ID; }
			set { _pRODUCT_CATEGORY_ID = value; }
		}

       

        public string PRODUCTTYPE
        {
            get { return _pRODUCTTYPE; }
            set { _pRODUCTTYPE = value; }
        }
	
		public string REMARKS
		{
			get { return _rEMARKS; }
			set { _rEMARKS = value; }
		}

        public string PRODUCT_TYPE_CODE
        {
            get { return _pRODUCT_TYPE_CODE; }
            set { _pRODUCT_TYPE_CODE = value; }
        }
		
		#region Methods

        public PRODUCT_TYPE()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	