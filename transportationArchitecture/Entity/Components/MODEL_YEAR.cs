using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class MODEL_YEAR : Entity.Framework.EntityBase
    {
        private string _pK_ID;

        public string PK_ID
        {
            get { return _pK_ID; }
            set { _pK_ID = value; }
        }
        private string _mODELYEAR;

        public string MODELYEAR
        {
            get { return _mODELYEAR; }
            set { _mODELYEAR = value; }
        }
	
		
		
		#region Methods

        public MODEL_YEAR()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	