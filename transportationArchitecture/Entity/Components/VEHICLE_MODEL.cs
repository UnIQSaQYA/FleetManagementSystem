using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class VEHICLE_MODEL : Entity.Framework.EntityBase
    {
        private string _pK_ID;
        private string _vEHICLE_TYPE_ID;

        private string _mODEL;
        private string _mANUFACTURE_ID;

        public string PK_ID
        {
            get { return _pK_ID; }
            set { _pK_ID = value; }
        }

        public string VEHICLE_TYPE_ID
        {
            get { return _vEHICLE_TYPE_ID; }
            set { _vEHICLE_TYPE_ID = value; }
        }
        public string MODEL
        {
            get { return _mODEL; }
            set { _mODEL = value; }
        }

        public string MANUFACTURE_ID
        {
            get { return _mANUFACTURE_ID; }
            set { _mANUFACTURE_ID = value; }
        }

        #region Methods

        public VEHICLE_MODEL()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
