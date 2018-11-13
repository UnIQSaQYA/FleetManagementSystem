using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class FIVE_DIMENSION_TEMP : Entity.Framework.EntityBase
    {
        private string _pK_ID;

        public string PK_ID
        {
            get { return _pK_ID; }
            set { _pK_ID = value; }
        }
		private string _vEHICLE_ID;
		private string _dIMENSION;
		private string _sCRATCH;
		private string _mISSING;
		private string _bROKEN;
		private string _dENTED;
		private string _oTHERS;
		private string _oTHER_DESCRIPTION;
	
		
		public string VEHICLE_ID
		{
			get { return _vEHICLE_ID; }
			set { _vEHICLE_ID = value; }
		}
	
		public string DIMENSION
		{
			get { return _dIMENSION; }
			set { _dIMENSION = value; }
		}
	
		public string SCRATCH
		{
			get { return _sCRATCH; }
			set { _sCRATCH = value; }
		}
	
		public string MISSING
		{
			get { return _mISSING; }
			set { _mISSING = value; }
		}
	
		public string BROKEN
		{
			get { return _bROKEN; }
			set { _bROKEN = value; }
		}
	
		public string DENTED
		{
			get { return _dENTED; }
			set { _dENTED = value; }
		}
	
		public string OTHERS
		{
			get { return _oTHERS; }
			set { _oTHERS = value; }
		}
	
		public string OTHER_DESCRIPTION
		{
			get { return _oTHER_DESCRIPTION; }
			set { _oTHER_DESCRIPTION = value; }
		}
		
		#region Methods

        public FIVE_DIMENSION_TEMP()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	