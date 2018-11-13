using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class DISTRICT : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _dISTRICT_NAME;
	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		public string DISTRICT_NAME
		{
			get { return _dISTRICT_NAME; }
			set { _dISTRICT_NAME = value; }
		}
		
		#region Methods

        public DISTRICT()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	