using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class GetCalendar : Entity.Framework.EntityBase
    {
        private string _mONTH;

        public string MONTH
        {
            get { return _mONTH; }
            set { _mONTH = value; }
        }
        private string _yEAR;

        public string YEAR
        {
            get { return _yEAR; }
            set { _yEAR = value; }
        }
        private string _dAYCOUNT;

        public string DAYCOUNT
        {
            get { return _dAYCOUNT; }
            set { _dAYCOUNT = value; }
        }
        private string _fIRSTDAY;

        public string FIRSTDAY
        {
            get { return _fIRSTDAY; }
            set { _fIRSTDAY = value; }
        }

      
		
		#region Methods

        public GetCalendar()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	