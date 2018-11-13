using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class fiscalyear : Entity.Framework.EntityBase
    {
		private string _fISCAL_YEAR;
		private string _sTART_DATE;
		private string _eND_DATE;
	
		public string FISCAL_YEAR
		{
			get { return _fISCAL_YEAR; }
			set { _fISCAL_YEAR = value; }
		}
	
		public string START_DATE
		{
			get { return _sTART_DATE; }
			set { _sTART_DATE = value; }
		}
	
		public string END_DATE
		{
			get { return _eND_DATE; }
			set { _eND_DATE = value; }
		}
		
		#region Methods

        public fiscalyear()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	