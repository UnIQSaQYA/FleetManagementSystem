using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class SubModules : Entity.Framework.EntityBase
    {
		private string _sUBMODULE_ID;
		private string _sUBMODULE_NAME;
		private string _mODULE_ID;
	
		public string SUBMODULE_ID
		{
			get { return _sUBMODULE_ID; }
			set { _sUBMODULE_ID = value; }
		}
	
		public string SUBMODULE_NAME
		{
			get { return _sUBMODULE_NAME; }
			set { _sUBMODULE_NAME = value; }
		}
	
		public string MODULE_ID
		{
			get { return _mODULE_ID; }
			set { _mODULE_ID = value; }
		}
		
		#region Methods

        public SubModules()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	