using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class MANUFACTURE : Entity.Framework.EntityBase
    {
        private string _pK_ID;
        private string _mANUFACTURE_NAME;
        private string _vEHICLE_TYPE_ID;

        public string VEHICLE_TYPE_ID
        {
            get { return _vEHICLE_TYPE_ID; }
            set { _vEHICLE_TYPE_ID = value; }
        }

        public string PK_ID
        {
            get { return _pK_ID; }
            set { _pK_ID = value; }
        }

        public string MANUFACTURE_NAME
        {
            get { return _mANUFACTURE_NAME; }
            set { _mANUFACTURE_NAME = value; }
        }
		
		#region Methods

        public MANUFACTURE()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	