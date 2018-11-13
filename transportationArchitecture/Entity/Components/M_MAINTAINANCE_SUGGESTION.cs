using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class M_MAINTAINANCE_SUGGESTION : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _jOB_CARD_ID;
		private string _sNO;
		private string _dESCRIPTION;
	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		public string JOB_CARD_ID
		{
			get { return _jOB_CARD_ID; }
			set { _jOB_CARD_ID = value; }
		}
	
		public string SNO
		{
			get { return _sNO; }
			set { _sNO = value; }
		}
	
		public string DESCRIPTION
		{
			get { return _dESCRIPTION; }
			set { _dESCRIPTION = value; }
		}
		
		#region Methods

        public M_MAINTAINANCE_SUGGESTION()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	