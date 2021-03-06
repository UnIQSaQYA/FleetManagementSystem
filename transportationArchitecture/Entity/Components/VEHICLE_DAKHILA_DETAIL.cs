﻿using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class VEHICLE_DAKHILA_DETAIL : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _vEHICLE_DAKHILA_ID;
		private string _sNO;
		private string _lFONO;
		private string _pRODUCT_ID;
		private string _qUANTITY;
		private string _rATE;
		private string _vAT;
		private string _oTHER_EXPENSE;
		private string _tOTAL;
		private string _bATCH;
		private string _lIFETIME;
		private string _rEMARKS;
	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		public string VEHICLE_DAKHILA_ID
		{
			get { return _vEHICLE_DAKHILA_ID; }
			set { _vEHICLE_DAKHILA_ID = value; }
		}
	
		public string SNO
		{
			get { return _sNO; }
			set { _sNO = value; }
		}
	
		public string LFONO
		{
			get { return _lFONO; }
			set { _lFONO = value; }
		}
	
		public string PRODUCT_ID
		{
			get { return _pRODUCT_ID; }
			set { _pRODUCT_ID = value; }
		}
	
		public string QUANTITY
		{
			get { return _qUANTITY; }
			set { _qUANTITY = value; }
		}
	
		public string RATE
		{
			get { return _rATE; }
			set { _rATE = value; }
		}
	
		public string VAT
		{
			get { return _vAT; }
			set { _vAT = value; }
		}
	
		public string OTHER_EXPENSE
		{
			get { return _oTHER_EXPENSE; }
			set { _oTHER_EXPENSE = value; }
		}
	
		public string TOTAL
		{
			get { return _tOTAL; }
			set { _tOTAL = value; }
		}
	
		public string BATCH
		{
			get { return _bATCH; }
			set { _bATCH = value; }
		}
	
		public string LIFETIME
		{
			get { return _lIFETIME; }
			set { _lIFETIME = value; }
		}
	
		public string REMARKS
		{
			get { return _rEMARKS; }
			set { _rEMARKS = value; }
		}
		
		#region Methods

        public VEHICLE_DAKHILA_DETAIL()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	