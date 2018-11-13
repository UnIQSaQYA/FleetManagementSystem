using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class TRAVEL_DESCRIPTION : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _mOVEMENT_ID;
		private string _tRAVEL_DATE;
		private string _tRAVEL_TIME;
		private string _pLACE_FROM;
		private string _pLACE_TO;
	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		public string MOVEMENT_ID
		{
			get { return _mOVEMENT_ID; }
			set { _mOVEMENT_ID = value; }
		}
	
		public string TRAVEL_DATE
		{
			get { return _tRAVEL_DATE; }
			set { _tRAVEL_DATE = value; }
		}
	
		public string TRAVEL_TIME
		{
			get { return _tRAVEL_TIME; }
			set { _tRAVEL_TIME = value; }
		}
	
		public string PLACE_FROM
		{
			get { return _pLACE_FROM; }
			set { _pLACE_FROM = value; }
		}
	
		public string PLACE_TO
		{
			get { return _pLACE_TO; }
			set { _pLACE_TO = value; }
		}
		
		#region Methods

        public TRAVEL_DESCRIPTION()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	