using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class GOOD_TRANSPORTATION : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _mOVEMENT_ID;
		private string _oRDER_OFFICE;
		private string _oRDER_BY_HEAD;
		private string _oRDER_BY;
	
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
	
		public string ORDER_OFFICE
		{
			get { return _oRDER_OFFICE; }
			set { _oRDER_OFFICE = value; }
		}
	
		public string ORDER_BY_HEAD
		{
			get { return _oRDER_BY_HEAD; }
			set { _oRDER_BY_HEAD = value; }
		}
	
		public string ORDER_BY
		{
			get { return _oRDER_BY; }
			set { _oRDER_BY = value; }
		}
		
		#region Methods

        public GOOD_TRANSPORTATION()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	