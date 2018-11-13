using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class DISPATCH_ISSUE_ACCESSORIES : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _dISPATCH_ISSUE;
		private string _dISPATCH_ISSUE_ID;
		private string _aCCESSORIES_ID;
	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		public string DISPATCH_ISSUE
		{
			get { return _dISPATCH_ISSUE; }
			set { _dISPATCH_ISSUE = value; }
		}
	
		public string DISPATCH_ISSUE_ID
		{
			get { return _dISPATCH_ISSUE_ID; }
			set { _dISPATCH_ISSUE_ID = value; }
		}
	
		public string ACCESSORIES_ID
		{
			get { return _aCCESSORIES_ID; }
			set { _aCCESSORIES_ID = value; }
		}
		
		#region Methods

        public DISPATCH_ISSUE_ACCESSORIES()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	