using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class SCRAP_RETURN_MASTER : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _rETURN_DAY;
		private string _rETURN_MONTH;
		private string _rETURN_YEAR;
		private string _rETURN_DATE;
		private string _rETURN_BY;
		private string _vEHICLE_REG_NO;
	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		public string RETURN_DAY
		{
			get { return _rETURN_DAY; }
			set { _rETURN_DAY = value; }
		}
	
		public string RETURN_MONTH
		{
			get { return _rETURN_MONTH; }
			set { _rETURN_MONTH = value; }
		}
	
		public string RETURN_YEAR
		{
			get { return _rETURN_YEAR; }
			set { _rETURN_YEAR = value; }
		}
	
		public string RETURN_DATE
		{
			get { return _rETURN_DATE; }
			set { _rETURN_DATE = value; }
		}
	
		public string RETURN_BY
		{
			get { return _rETURN_BY; }
			set { _rETURN_BY = value; }
		}
	
		public string VEHICLE_REG_NO
		{
			get { return _vEHICLE_REG_NO; }
			set { _vEHICLE_REG_NO = value; }
		}
		
		#region Methods

        public SCRAP_RETURN_MASTER()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	