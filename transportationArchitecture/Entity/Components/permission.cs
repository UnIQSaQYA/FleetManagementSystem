using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class permission : Entity.Framework.EntityBase
    {
		private string _pERM_ID;
		private string _gROUP_ID;
	
        private string _PageID;
		private string _pERMISSION_SUB;
    

        public string PageID
		{
            get { return _PageID; }
            set { _PageID = value; }
		}

        public string PERM_ID
        {
            get { return _pERM_ID; }
            set { _pERM_ID = value; }
        }

		public string GROUP_ID
		{
			get { return _gROUP_ID; }
			set { _gROUP_ID = value; }
		}
	
		
		public string PERMISSION_SUB
		{
			get { return _pERMISSION_SUB; }
			set { _pERMISSION_SUB = value; }
		}

     
		
		#region Methods

        public permission()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	