using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class PRODUCT_CATEGORY : Entity.Framework.EntityBase
    {
		private string _pK_ID;
        private string _pRODUCTCATEGORY;
        private string _pRODUCT_CATEGORY_CODE;

        public string PRODUCT_CATEGORY_CODE
        {
            get { return _pRODUCT_CATEGORY_CODE; }
            set { _pRODUCT_CATEGORY_CODE = value; }
        }

        public string PRODUCTCATEGORY
        {
            get { return _pRODUCTCATEGORY; }
            set { _pRODUCTCATEGORY = value; }
        }

		private string _rEMARKS;
	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		
	
		public string REMARKS
		{
			get { return _rEMARKS; }
			set { _rEMARKS = value; }
		}
		
		#region Methods

        public PRODUCT_CATEGORY()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	