using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class POST_OPERATION_LIST : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _vEHICLE_DISPATCH_ID;
        private string _pOST_OPERATIONLIST;

        public string POST_OPERATIONLIST
        {
            get { return _pOST_OPERATIONLIST; }
            set { _pOST_OPERATIONLIST = value; }
        }
	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		public string VEHICLE_DISPATCH_ID
		{
			get { return _vEHICLE_DISPATCH_ID; }
			set { _vEHICLE_DISPATCH_ID = value; }
		}
	
		
		#region Methods

        public POST_OPERATION_LIST()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	