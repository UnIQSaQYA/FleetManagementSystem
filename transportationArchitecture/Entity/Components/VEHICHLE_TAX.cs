using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class VEHICHLE_TAX : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _vECHICLE_ID;
		private string _rECEIPT_NO;
		private string _rECEIPT_DAY;
		private string _rECEIPT_MONTH;
		private string _rECEIPT_YEAR;
		private string _aMOUNT;
	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		public string VECHICLE_ID
		{
			get { return _vECHICLE_ID; }
			set { _vECHICLE_ID = value; }
		}
	
		public string RECEIPT_NO
		{
			get { return _rECEIPT_NO; }
			set { _rECEIPT_NO = value; }
		}
	
		public string RECEIPT_DAY
		{
			get { return _rECEIPT_DAY; }
			set { _rECEIPT_DAY = value; }
		}
	
		public string RECEIPT_MONTH
		{
			get { return _rECEIPT_MONTH; }
			set { _rECEIPT_MONTH = value; }
		}
	
		public string RECEIPT_YEAR
		{
			get { return _rECEIPT_YEAR; }
			set { _rECEIPT_YEAR = value; }
		}
	
		public string AMOUNT
		{
			get { return _aMOUNT; }
			set { _aMOUNT = value; }
		}
		
		#region Methods

        public VEHICHLE_TAX()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	