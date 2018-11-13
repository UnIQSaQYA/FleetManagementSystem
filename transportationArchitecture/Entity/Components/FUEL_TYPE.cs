using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class FUEL_TYPE : Entity.Framework.EntityBase
    {
		private string _pK_ID;
        private string _fUELTYPE;

        public string FUELTYPE
        {
            get { return _fUELTYPE; }
            set { _fUELTYPE = value; }
        }
	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		
		
		#region Methods

        public FUEL_TYPE()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	