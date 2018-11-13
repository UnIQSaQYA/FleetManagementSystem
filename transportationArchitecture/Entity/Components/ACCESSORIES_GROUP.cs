using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class ACCESSORIES_GROUP : Entity.Framework.EntityBase
    {
		private string _pK_ID;
        private string _aCCESSORIESGROUP;

        public string ACCESSORIESGROUP
        {
            get { return _aCCESSORIESGROUP; }
            set { _aCCESSORIESGROUP = value; }
        }
	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
	
		
		#region Methods

        public ACCESSORIES_GROUP()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	