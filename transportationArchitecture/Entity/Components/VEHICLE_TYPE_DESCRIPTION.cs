using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class VEHICLE_TYPE_DESCRIPTION : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _vEHICLE_TYPE_ID;
        private string _vEHICLE_TYPEDESCRIPTION;

        public string VEHICLE_TYPEDESCRIPTION
        {
            get { return _vEHICLE_TYPEDESCRIPTION; }
            set { _vEHICLE_TYPEDESCRIPTION = value; }
        }
	
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
	
		
		
		#region Methods

        public VEHICLE_TYPE_DESCRIPTION()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	