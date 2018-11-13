using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class Modules : Entity.Framework.EntityBase
    {
		private string _mODULE_ID;
		private string _mODULE_NAME;
		private string _lEAF_NODE;
		private string _pARENT_MODULE;
	
		public string MODULE_ID
		{
			get { return _mODULE_ID; }
			set { _mODULE_ID = value; }
		}
	
		public string MODULE_NAME
		{
			get { return _mODULE_NAME; }
			set { _mODULE_NAME = value; }
		}
	
		public string LEAF_NODE
		{
			get { return _lEAF_NODE; }
			set { _lEAF_NODE = value; }
		}
	
		public string PARENT_MODULE
		{
			get { return _pARENT_MODULE; }
			set { _pARENT_MODULE = value; }
		}
		
		#region Methods

        public Modules()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	