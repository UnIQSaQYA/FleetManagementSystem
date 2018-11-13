using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class UNIT : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _uNIT_NAME;
	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		public string UNIT_NAME
		{
			get { return _uNIT_NAME; }
			set { _uNIT_NAME = value; }
		}
		
		#region Methods

        public UNIT()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	