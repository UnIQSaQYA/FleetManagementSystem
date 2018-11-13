using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class GOOD_TRANSPORTATION_DETAIL : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _gOOD_TRANSPORT_ID;
		private string _sNO;
		private string _pARTICULAR;
		private string _uNIT;
		private string _qTY;
		private string _rEMARKS;
	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		public string GOOD_TRANSPORT_ID
		{
			get { return _gOOD_TRANSPORT_ID; }
			set { _gOOD_TRANSPORT_ID = value; }
		}
	
		public string SNO
		{
			get { return _sNO; }
			set { _sNO = value; }
		}
	
		public string PARTICULAR
		{
			get { return _pARTICULAR; }
			set { _pARTICULAR = value; }
		}
	
		public string UNIT
		{
			get { return _uNIT; }
			set { _uNIT = value; }
		}
	
		public string QTY
		{
			get { return _qTY; }
			set { _qTY = value; }
		}
	
		public string REMARKS
		{
			get { return _rEMARKS; }
			set { _rEMARKS = value; }
		}
		
		#region Methods

        public GOOD_TRANSPORTATION_DETAIL()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	