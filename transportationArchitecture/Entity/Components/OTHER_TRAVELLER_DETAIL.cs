using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class OTHER_TRAVELLER_DETAIL : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _mOVEMENT_ID;
		private string _sNO;
		private string _pERSON;
		private string _rELATION;
		private string _gOODS_CARRIED;
		private string _qTY;
	
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
	
		public string SNO
		{
			get { return _sNO; }
			set { _sNO = value; }
		}
	
		public string PERSON
		{
			get { return _pERSON; }
			set { _pERSON = value; }
		}
	
		public string RELATION
		{
			get { return _rELATION; }
			set { _rELATION = value; }
		}
	
		public string GOODS_CARRIED
		{
			get { return _gOODS_CARRIED; }
			set { _gOODS_CARRIED = value; }
		}
	
		public string QTY
		{
			get { return _qTY; }
			set { _qTY = value; }
		}
		
		#region Methods

        public OTHER_TRAVELLER_DETAIL()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	