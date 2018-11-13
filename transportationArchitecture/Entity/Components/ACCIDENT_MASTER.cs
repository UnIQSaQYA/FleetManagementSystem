using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class ACCIDENT_MASTER : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _aCCIDENT_TYPE;
		private string _rEMARKS;
        private string _pARENT_ID;

      

		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		public string ACCIDENT_TYPE
		{
			get { return _aCCIDENT_TYPE; }
			set { _aCCIDENT_TYPE = value; }
		}
	
		public string REMARKS
		{
			get { return _rEMARKS; }
			set { _rEMARKS = value; }
		}

        public string PARENT_ID
        {
            get { return _pARENT_ID; }
            set { _pARENT_ID = value; }
        }
		#region Methods

        public ACCIDENT_MASTER()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	