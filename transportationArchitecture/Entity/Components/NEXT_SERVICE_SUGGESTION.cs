using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class NEXT_SERVICE_SUGGESTION : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _nEXT_SERVICE_ID;
		private string _sERVICE_SUGGESTION;
	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		public string NEXT_SERVICE_ID
		{
			get { return _nEXT_SERVICE_ID; }
			set { _nEXT_SERVICE_ID = value; }
		}
	
		public string SERVICE_SUGGESTION
		{
			get { return _sERVICE_SUGGESTION; }
			set { _sERVICE_SUGGESTION = value; }
		}
		
		#region Methods

        public NEXT_SERVICE_SUGGESTION()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	