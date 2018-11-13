using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class Groups : Entity.Framework.EntityBase
    {
		private string _gROUPID;
		private string _gROUPNAME;
		private string _gROUPPRECEDENCE;
		private string _gROUPDETAILS;
	
		public string GROUPID
		{
			get { return _gROUPID; }
			set { _gROUPID = value; }
		}
	
		public string GROUPNAME
		{
			get { return _gROUPNAME; }
			set { _gROUPNAME = value; }
		}
	
		public string GROUPPRECEDENCE
		{
			get { return _gROUPPRECEDENCE; }
			set { _gROUPPRECEDENCE = value; }
		}
	
		public string GROUPDETAILS
		{
			get { return _gROUPDETAILS; }
			set { _gROUPDETAILS = value; }
		}
		
		#region Methods

        public Groups()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	