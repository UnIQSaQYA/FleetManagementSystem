using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class USERGROUP : Entity.Framework.EntityBase
    {
		private string _uSERGROUPID;
		private string _uSERID;       
		private string _gROUPID;
       
      
		public string USERGROUPID
		{
			get { return _uSERGROUPID; }
			set { _uSERGROUPID = value; }
		}
	
		public string USERID
		{
			get { return _uSERID; }
			set { _uSERID = value; }
		}
	
		public string GROUPID
		{
			get { return _gROUPID; }
			set { _gROUPID = value; }
		}
		
		#region Methods

        public USERGROUP()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	