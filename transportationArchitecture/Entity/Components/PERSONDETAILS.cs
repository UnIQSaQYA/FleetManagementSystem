using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class PERSONDETAILS : Entity.Framework.EntityBase
    {
		private string _cODE;
		private string _nAME;
		private string _fATHER_NAME;
		private string _gRAND_FATHER_NAME;
		private string _rNK;
		private string _pIS;
		private string _pOSITION;
		private string _aDDRESS;
		private string _mOJ;
		private string _mOR;
		private string _cURRENT_UNIT;
		private string _jOB_STATUS;
	
		public string CODE
		{
			get { return _cODE; }
			set { _cODE = value; }
		}
	
		public string NAME
		{
			get { return _nAME; }
			set { _nAME = value; }
		}
	
		public string FATHER_NAME
		{
			get { return _fATHER_NAME; }
			set { _fATHER_NAME = value; }
		}
	
		public string GRAND_FATHER_NAME
		{
			get { return _gRAND_FATHER_NAME; }
			set { _gRAND_FATHER_NAME = value; }
		}
	
		public string RNK
		{
			get { return _rNK; }
			set { _rNK = value; }
		}
	
		public string PIS
		{
			get { return _pIS; }
			set { _pIS = value; }
		}
	
		public string POSITION
		{
			get { return _pOSITION; }
			set { _pOSITION = value; }
		}
	
		public string ADDRESS
		{
			get { return _aDDRESS; }
			set { _aDDRESS = value; }
		}
	
		public string MOJ
		{
			get { return _mOJ; }
			set { _mOJ = value; }
		}
	
		public string MOR
		{
			get { return _mOR; }
			set { _mOR = value; }
		}
	
		public string CURRENT_UNIT
		{
			get { return _cURRENT_UNIT; }
			set { _cURRENT_UNIT = value; }
		}
	
		public string JOB_STATUS
		{
			get { return _jOB_STATUS; }
			set { _jOB_STATUS = value; }
		}
		
		#region Methods

        public PERSONDETAILS()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	