using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class MOVEMENT_OF_VEHICLE : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _tRAVEL_NUMBER;
		private string _tRAVEL_DAY;
		private string _tRAVEL_MONTH;
		private string _tRAVEL_YEAR;
		private string _tRAVEL_DATE;
		private string _tRAVEL_FY;
		private string _vEHICLE_REG_NO;
		private string _dRIVER_ID;
		private string _tVL_MAIN_PERSON;
		private string _tVL_MAIN_CONTACTNO;
		private string _tV_MAIN_MOBILENO;
		private string _tVL_MAIN_CALLSIGN;
		private string _tVL_REASON;
		private string _tVL_TYPE;
		private string _tVL_REF_DEMAND_BY;
		private string _tVL_REF_DEMAND_OFFICE;
		private string _tVL_REF_DEMAND_DIS;
		private string _tVL_REF_APPROVE_BY;
		private string _tVL_REF_APPROVE_OFFICE;
		private string _tVL_REF_APPROVE_DIS;
		private string _tVL_APPROVE_BY;
		private string _tVL_APPROVE_OFFICE;
		private string _tVL_APPROVE_DIS;
		private string _tVL_COMPLITION_DETAIL;

        private string _fUEL_SOURCE;

       
        private string _fUEL_QUANTITY;

       
	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		public string TRAVEL_NUMBER
		{
			get { return _tRAVEL_NUMBER; }
			set { _tRAVEL_NUMBER = value; }
		}
	
		public string TRAVEL_DAY
		{
			get { return _tRAVEL_DAY; }
			set { _tRAVEL_DAY = value; }
		}
	
		public string TRAVEL_MONTH
		{
			get { return _tRAVEL_MONTH; }
			set { _tRAVEL_MONTH = value; }
		}
	
		public string TRAVEL_YEAR
		{
			get { return _tRAVEL_YEAR; }
			set { _tRAVEL_YEAR = value; }
		}
	
		public string TRAVEL_DATE
		{
			get { return _tRAVEL_DATE; }
			set { _tRAVEL_DATE = value; }
		}
	
		public string TRAVEL_FY
		{
			get { return _tRAVEL_FY; }
			set { _tRAVEL_FY = value; }
		}
	
		public string VEHICLE_REG_NO
		{
			get { return _vEHICLE_REG_NO; }
			set { _vEHICLE_REG_NO = value; }
		}
	
		public string DRIVER_ID
		{
			get { return _dRIVER_ID; }
			set { _dRIVER_ID = value; }
		}
	
		public string TVL_MAIN_PERSON
		{
			get { return _tVL_MAIN_PERSON; }
			set { _tVL_MAIN_PERSON = value; }
		}
	
		public string TVL_MAIN_CONTACTNO
		{
			get { return _tVL_MAIN_CONTACTNO; }
			set { _tVL_MAIN_CONTACTNO = value; }
		}
	
		public string TV_MAIN_MOBILENO
		{
			get { return _tV_MAIN_MOBILENO; }
			set { _tV_MAIN_MOBILENO = value; }
		}
	
		public string TVL_MAIN_CALLSIGN
		{
			get { return _tVL_MAIN_CALLSIGN; }
			set { _tVL_MAIN_CALLSIGN = value; }
		}
	
		public string TVL_REASON
		{
			get { return _tVL_REASON; }
			set { _tVL_REASON = value; }
		}
	
		public string TVL_TYPE
		{
			get { return _tVL_TYPE; }
			set { _tVL_TYPE = value; }
		}
	
		public string TVL_REF_DEMAND_BY
		{
			get { return _tVL_REF_DEMAND_BY; }
			set { _tVL_REF_DEMAND_BY = value; }
		}
	
		public string TVL_REF_DEMAND_OFFICE
		{
			get { return _tVL_REF_DEMAND_OFFICE; }
			set { _tVL_REF_DEMAND_OFFICE = value; }
		}
	
		public string TVL_REF_DEMAND_DIS
		{
			get { return _tVL_REF_DEMAND_DIS; }
			set { _tVL_REF_DEMAND_DIS = value; }
		}
	
		public string TVL_REF_APPROVE_BY
		{
			get { return _tVL_REF_APPROVE_BY; }
			set { _tVL_REF_APPROVE_BY = value; }
		}
	
		public string TVL_REF_APPROVE_OFFICE
		{
			get { return _tVL_REF_APPROVE_OFFICE; }
			set { _tVL_REF_APPROVE_OFFICE = value; }
		}
	
		public string TVL_REF_APPROVE_DIS
		{
			get { return _tVL_REF_APPROVE_DIS; }
			set { _tVL_REF_APPROVE_DIS = value; }
		}
	
		public string TVL_APPROVE_BY
		{
			get { return _tVL_APPROVE_BY; }
			set { _tVL_APPROVE_BY = value; }
		}
	
		public string TVL_APPROVE_OFFICE
		{
			get { return _tVL_APPROVE_OFFICE; }
			set { _tVL_APPROVE_OFFICE = value; }
		}
	
		public string TVL_APPROVE_DIS
		{
			get { return _tVL_APPROVE_DIS; }
			set { _tVL_APPROVE_DIS = value; }
		}
	
		public string TVL_COMPLITION_DETAIL
		{
			get { return _tVL_COMPLITION_DETAIL; }
			set { _tVL_COMPLITION_DETAIL = value; }
		}

        public string FUEL_SOURCE
        {
            get { return _fUEL_SOURCE; }
            set { _fUEL_SOURCE = value; }
        }
        public string FUEL_QUANTITY
        {
            get { return _fUEL_QUANTITY; }
            set { _fUEL_QUANTITY = value; }
        }
		
		#region Methods

        public MOVEMENT_OF_VEHICLE()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	