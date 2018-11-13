using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class login_fiscal_year : Entity.Framework.EntityBase
    {
        private string _fISCAL_YEAR;

        public string FISCAL_YEAR
        {
            get { return _fISCAL_YEAR; }
            set { _fISCAL_YEAR = value; }
        }
		
		
		#region Methods

        public login_fiscal_year()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	