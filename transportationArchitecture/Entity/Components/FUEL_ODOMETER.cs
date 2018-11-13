using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class FUEL_ODOMETER : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _vEHICLE_REG_NO;
		private string _fUEL_DAY;
		private string _fUEL_MONTH;
		private string _fUEL_YEAR;
		private string _fUEL_DATE;
		private string _pETROL;
		private string _dIESEL;
		private string _mOBIL;
		private string _dISTILLED_WATER;
		private string _oDOMETER;
		private string _fUEL_STATION_TYPE;
		private string _fUEL_STATION;
		private string _rEFUEL_BY;
		private string _rATE_PETROL;
		private string _rATE_DIESEL;
		private string _rATE_MOBIL;
		private string _rATE_DISTILLED_WATER;
        private string _fUEL_TYPE;

        public string FUEL_TYPE
        {
            get { return _fUEL_TYPE; }
            set { _fUEL_TYPE = value; }
        }

		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		public string VEHICLE_REG_NO
		{
			get { return _vEHICLE_REG_NO; }
			set { _vEHICLE_REG_NO = value; }
		}
	
		public string FUEL_DAY
		{
			get { return _fUEL_DAY; }
			set { _fUEL_DAY = value; }
		}
	
		public string FUEL_MONTH
		{
			get { return _fUEL_MONTH; }
			set { _fUEL_MONTH = value; }
		}
	
		public string FUEL_YEAR
		{
			get { return _fUEL_YEAR; }
			set { _fUEL_YEAR = value; }
		}
	
		public string FUEL_DATE
		{
			get { return _fUEL_DATE; }
			set { _fUEL_DATE = value; }
		}
	
		public string PETROL
		{
			get { return _pETROL; }
			set { _pETROL = value; }
		}
	
		public string DIESEL
		{
			get { return _dIESEL; }
			set { _dIESEL = value; }
		}
	
		public string MOBIL
		{
			get { return _mOBIL; }
			set { _mOBIL = value; }
		}
	
		public string DISTILLED_WATER
		{
			get { return _dISTILLED_WATER; }
			set { _dISTILLED_WATER = value; }
		}
	
		public string ODOMETER
		{
			get { return _oDOMETER; }
			set { _oDOMETER = value; }
		}
	
		public string FUEL_STATION_TYPE
		{
			get { return _fUEL_STATION_TYPE; }
			set { _fUEL_STATION_TYPE = value; }
		}
	
		public string FUEL_STATION
		{
			get { return _fUEL_STATION; }
			set { _fUEL_STATION = value; }
		}
	
		public string REFUEL_BY
		{
			get { return _rEFUEL_BY; }
			set { _rEFUEL_BY = value; }
		}
	
		public string RATE_PETROL
		{
			get { return _rATE_PETROL; }
			set { _rATE_PETROL = value; }
		}
	
		public string RATE_DIESEL
		{
			get { return _rATE_DIESEL; }
			set { _rATE_DIESEL = value; }
		}
	
		public string RATE_MOBIL
		{
			get { return _rATE_MOBIL; }
			set { _rATE_MOBIL = value; }
		}
	
		public string RATE_DISTILLED_WATER
		{
			get { return _rATE_DISTILLED_WATER; }
			set { _rATE_DISTILLED_WATER = value; }
		}
		
		#region Methods

        public FUEL_ODOMETER()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	