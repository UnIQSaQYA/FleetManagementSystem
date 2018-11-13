using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class BASE_STATION : Entity.Framework.EntityBase
    {
		private string _pK_ID;
        private string _bASESTATION;

        public string BASESTATION
        {
            get { return _bASESTATION; }
            set { _bASESTATION = value; }
        }
	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		
		#region Methods

        public BASE_STATION()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	