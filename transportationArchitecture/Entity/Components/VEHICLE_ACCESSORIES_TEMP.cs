using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;


namespace Entity.Components
{
    public class VEHICLE_ACCESSORIES_TEMP : Entity.Framework.EntityBase
    {
        private string _pK_ID;
        private string _sN;
        private string _aCCESSORIES_ID;

        public string SN
        {
            get { return _sN; }
            set { _sN = value; }
        }

        public string ACCESSORIES_ID
        {
            get { return _aCCESSORIES_ID; }
            set { _aCCESSORIES_ID = value; }
        }


        public string PK_ID
        {
            get { return _pK_ID; }
            set { _pK_ID = value; }
        }

        		#region Methods

        public VEHICLE_ACCESSORIES_TEMP()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
