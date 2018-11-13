using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class M_NEXT_SERVICE : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _vEHICLE_REG_NO;
		private string _nEXT_SER_DAY;
		private string _nEXT_SER_MONTH;
		private string _nEXT_SER_YEAR;
		private string _nEXT_SER_DATE;
		private string _nEXT_SER_KM;
        private string _cOMPLITION_ID;

        public string COMPLITION_ID
        {
            get { return _cOMPLITION_ID; }
            set { _cOMPLITION_ID = value; }
        }
	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		public string VEHICLE_REG_NO
		{
			get { return _vEHICLE_REG_NO; }
			set { _vEHICLE_REG_NO = value; }
		}
	
		public string NEXT_SER_DAY
		{
			get { return _nEXT_SER_DAY; }
			set { _nEXT_SER_DAY = value; }
		}
	
		public string NEXT_SER_MONTH
		{
			get { return _nEXT_SER_MONTH; }
			set { _nEXT_SER_MONTH = value; }
		}
	
		public string NEXT_SER_YEAR
		{
			get { return _nEXT_SER_YEAR; }
			set { _nEXT_SER_YEAR = value; }
		}
	
		public string NEXT_SER_DATE
		{
			get { return _nEXT_SER_DATE; }
			set { _nEXT_SER_DATE = value; }
		}
	
		public string NEXT_SER_KM
		{
			get { return _nEXT_SER_KM; }
			set { _nEXT_SER_KM = value; }
		}
		
		#region Methods

        public M_NEXT_SERVICE()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	