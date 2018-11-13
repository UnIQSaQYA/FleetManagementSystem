using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class VEHICLE_AT_OFFICE : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _vEHICLE_ID;
		private string _oFFICE_ID;
		private string _vAO_DATE;
		private string _vAO_DAY;
		private string _vAO_MONTH;
		private string _vAO_YEAR;
		private string _tRANSFER_PURCHASE_ID;
        private string _tRANSFER_PURCHASE;

       
		private string _sTATUS;
        private string _pERSON_ID;

       

	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		public string VEHICLE_ID
		{
			get { return _vEHICLE_ID; }
			set { _vEHICLE_ID = value; }
		}
	
		public string OFFICE_ID
		{
			get { return _oFFICE_ID; }
			set { _oFFICE_ID = value; }
		}
	
		public string VAO_DATE
		{
			get { return _vAO_DATE; }
			set { _vAO_DATE = value; }
		}
	
		public string VAO_DAY
		{
			get { return _vAO_DAY; }
			set { _vAO_DAY = value; }
		}
	
		public string VAO_MONTH
		{
			get { return _vAO_MONTH; }
			set { _vAO_MONTH = value; }
		}
	
		public string VAO_YEAR
		{
			get { return _vAO_YEAR; }
			set { _vAO_YEAR = value; }
		}
	
		public string TRANSFER_PURCHASE_ID
		{
			get { return _tRANSFER_PURCHASE_ID; }
			set { _tRANSFER_PURCHASE_ID = value; }
		}
	
		public string STATUS
		{
			get { return _sTATUS; }
			set { _sTATUS = value; }
		}

        public string TRANSFER_PURCHASE
        {
            get { return _tRANSFER_PURCHASE; }
            set { _tRANSFER_PURCHASE = value; }
        }
        public string PERSON_ID
        {
            get { return _pERSON_ID; }
            set { _pERSON_ID = value; }
        }
		
		#region Methods

        public VEHICLE_AT_OFFICE()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	