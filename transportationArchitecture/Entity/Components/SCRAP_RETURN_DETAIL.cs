using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class SCRAP_RETURN_DETAIL : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _sCRAP_RETURN_ID;
		private string _pRODUCT_ID;
		private string _sTORE_AT;
		private string _rEMARKS;
	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		public string SCRAP_RETURN_ID
		{
			get { return _sCRAP_RETURN_ID; }
			set { _sCRAP_RETURN_ID = value; }
		}
	
		public string PRODUCT_ID
		{
			get { return _pRODUCT_ID; }
			set { _pRODUCT_ID = value; }
		}
	
		public string STORE_AT
		{
			get { return _sTORE_AT; }
			set { _sTORE_AT = value; }
		}
	
		public string REMARKS
		{
			get { return _rEMARKS; }
			set { _rEMARKS = value; }
		}
		
		#region Methods

        public SCRAP_RETURN_DETAIL()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	