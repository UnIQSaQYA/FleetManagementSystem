using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class M_LABOR_TYPE : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _lABOUR_MASTER;
		private string _pARENT;
	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		public string LABOUR_MASTER
		{
			get { return _lABOUR_MASTER; }
			set { _lABOUR_MASTER = value; }
		}
	
		public string PARENT
		{
			get { return _pARENT; }
			set { _pARENT = value; }
		}
		
		#region Methods

        public M_LABOR_TYPE()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	