using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class VEHICLE_DISPATCH : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _dISPATCH_NUMBER;
		private string _vEHICLE_ID;
		private string _dRIVERS_ID;
		private string _dISPATCH_DAY;
		private string _dISPATCH_MONTH;
		private string _dISPATCH_YEAR;
		private string _dISPATCH_DATE;
		private string _dISPATCH_TIME;
		private string _dISPATCH_ODOMETER;
		private string _rETURN_DAY;
		private string _rETURN_MONTH;
		private string _rETURN_YEAR;
		private string _rETURN_DATE;
		private string _rETURN_TIME;
		private string _dESTINATION;
		private string _pARKING_PLACE;
		private string _sCHEDULED_MAINTAIN_DATE;
		private string _sCHEDULED_MAINTAIN_MILAGE;
		private string _oUTSTANDING_REPAIR;
		private string _uNIT_PERSON_STATUS;
		private string _uNIT_PERSON;
		private string _tEMPORARY_PERMANENT;
		private string _oFFICE_CODE;
	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		public string DISPATCH_NUMBER
		{
			get { return _dISPATCH_NUMBER; }
			set { _dISPATCH_NUMBER = value; }
		}
	
		public string VEHICLE_ID
		{
			get { return _vEHICLE_ID; }
			set { _vEHICLE_ID = value; }
		}
	
		public string DRIVERS_ID
		{
			get { return _dRIVERS_ID; }
			set { _dRIVERS_ID = value; }
		}
	
		public string DISPATCH_DAY
		{
			get { return _dISPATCH_DAY; }
			set { _dISPATCH_DAY = value; }
		}
	
		public string DISPATCH_MONTH
		{
			get { return _dISPATCH_MONTH; }
			set { _dISPATCH_MONTH = value; }
		}
	
		public string DISPATCH_YEAR
		{
			get { return _dISPATCH_YEAR; }
			set { _dISPATCH_YEAR = value; }
		}
	
		public string DISPATCH_DATE
		{
			get { return _dISPATCH_DATE; }
			set { _dISPATCH_DATE = value; }
		}
	
		public string DISPATCH_TIME
		{
			get { return _dISPATCH_TIME; }
			set { _dISPATCH_TIME = value; }
		}
	
		public string DISPATCH_ODOMETER
		{
			get { return _dISPATCH_ODOMETER; }
			set { _dISPATCH_ODOMETER = value; }
		}
	
		public string RETURN_DAY
		{
			get { return _rETURN_DAY; }
			set { _rETURN_DAY = value; }
		}
	
		public string RETURN_MONTH
		{
			get { return _rETURN_MONTH; }
			set { _rETURN_MONTH = value; }
		}
	
		public string RETURN_YEAR
		{
			get { return _rETURN_YEAR; }
			set { _rETURN_YEAR = value; }
		}
	
		public string RETURN_DATE
		{
			get { return _rETURN_DATE; }
			set { _rETURN_DATE = value; }
		}
	
		public string RETURN_TIME
		{
			get { return _rETURN_TIME; }
			set { _rETURN_TIME = value; }
		}
	
		public string DESTINATION
		{
			get { return _dESTINATION; }
			set { _dESTINATION = value; }
		}
	
		public string PARKING_PLACE
		{
			get { return _pARKING_PLACE; }
			set { _pARKING_PLACE = value; }
		}
	
		public string SCHEDULED_MAINTAIN_DATE
		{
			get { return _sCHEDULED_MAINTAIN_DATE; }
			set { _sCHEDULED_MAINTAIN_DATE = value; }
		}
	
		public string SCHEDULED_MAINTAIN_MILAGE
		{
			get { return _sCHEDULED_MAINTAIN_MILAGE; }
			set { _sCHEDULED_MAINTAIN_MILAGE = value; }
		}
	
		public string OUTSTANDING_REPAIR
		{
			get { return _oUTSTANDING_REPAIR; }
			set { _oUTSTANDING_REPAIR = value; }
		}
	
		public string UNIT_PERSON_STATUS
		{
			get { return _uNIT_PERSON_STATUS; }
			set { _uNIT_PERSON_STATUS = value; }
		}
	
		public string UNIT_PERSON
		{
			get { return _uNIT_PERSON; }
			set { _uNIT_PERSON = value; }
		}
	
		public string TEMPORARY_PERMANENT
		{
			get { return _tEMPORARY_PERMANENT; }
			set { _tEMPORARY_PERMANENT = value; }
		}
	
		public string OFFICE_CODE
		{
			get { return _oFFICE_CODE; }
			set { _oFFICE_CODE = value; }
		}
		
		#region Methods

        public VEHICLE_DISPATCH()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	