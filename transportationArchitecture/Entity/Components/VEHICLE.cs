using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class VEHICLE : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _cHASIS_NUMBER;
		private string _rEGISTRATION_NUMBER_ENG;
		private string _rEGISTRATION_NUMBER_NEP;
		private string _eNGINE_NUMBER;
		private string _rEGISTRATION_DAY;
		private string _rEGISTRATION_MONTH;
		private string _rEGISTRATION_YEAR;
		private string _rEGISTRATION_DATE;
		private string _mANUFACTURE;
		private string _vECHICLE_MODEL;
		private string _mODEL_YEAR;
		private string _vEHICLE_CATEGORY;
		private string _vEHICLE_TYPE;
		private string _vEHICLE_TYPE_DESCRIPTION;
		private string _mAX_CARGO_CAPACITY;
		private string _mAX_PASSENGER_CAPACITY;
		private string _fUEL_TYPE;
		private string _mAINTENANCE_INTERVAL_MONTH;
		private string _mAINTENANCE_INTERVAL_KM;
		private string _vECHICLE_USER;
		private string _bASE_STATION;
		private string _vEHICLE_STATUS;
	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		public string CHASIS_NUMBER
		{
			get { return _cHASIS_NUMBER; }
			set { _cHASIS_NUMBER = value; }
		}
	
		public string REGISTRATION_NUMBER_ENG
		{
			get { return _rEGISTRATION_NUMBER_ENG; }
			set { _rEGISTRATION_NUMBER_ENG = value; }
		}
	
		public string REGISTRATION_NUMBER_NEP
		{
			get { return _rEGISTRATION_NUMBER_NEP; }
			set { _rEGISTRATION_NUMBER_NEP = value; }
		}
	
		public string ENGINE_NUMBER
		{
			get { return _eNGINE_NUMBER; }
			set { _eNGINE_NUMBER = value; }
		}
	
		public string REGISTRATION_DAY
		{
			get { return _rEGISTRATION_DAY; }
			set { _rEGISTRATION_DAY = value; }
		}
	
		public string REGISTRATION_MONTH
		{
			get { return _rEGISTRATION_MONTH; }
			set { _rEGISTRATION_MONTH = value; }
		}
	
		public string REGISTRATION_YEAR
		{
			get { return _rEGISTRATION_YEAR; }
			set { _rEGISTRATION_YEAR = value; }
		}
	
		public string REGISTRATION_DATE
		{
			get { return _rEGISTRATION_DATE; }
			set { _rEGISTRATION_DATE = value; }
		}
	
		public string MANUFACTURE
		{
			get { return _mANUFACTURE; }
			set { _mANUFACTURE = value; }
		}
	
		public string VECHICLE_MODEL
		{
			get { return _vECHICLE_MODEL; }
			set { _vECHICLE_MODEL = value; }
		}
	
		public string MODEL_YEAR
		{
			get { return _mODEL_YEAR; }
			set { _mODEL_YEAR = value; }
		}
	
		public string VEHICLE_CATEGORY
		{
			get { return _vEHICLE_CATEGORY; }
			set { _vEHICLE_CATEGORY = value; }
		}
	
		public string VEHICLE_TYPE
		{
			get { return _vEHICLE_TYPE; }
			set { _vEHICLE_TYPE = value; }
		}
	
		public string VEHICLE_TYPE_DESCRIPTION
		{
			get { return _vEHICLE_TYPE_DESCRIPTION; }
			set { _vEHICLE_TYPE_DESCRIPTION = value; }
		}
	
		public string MAX_CARGO_CAPACITY
		{
			get { return _mAX_CARGO_CAPACITY; }
			set { _mAX_CARGO_CAPACITY = value; }
		}
	
		public string MAX_PASSENGER_CAPACITY
		{
			get { return _mAX_PASSENGER_CAPACITY; }
			set { _mAX_PASSENGER_CAPACITY = value; }
		}
	
		public string FUEL_TYPE
		{
			get { return _fUEL_TYPE; }
			set { _fUEL_TYPE = value; }
		}
	
		public string MAINTENANCE_INTERVAL_MONTH
		{
			get { return _mAINTENANCE_INTERVAL_MONTH; }
			set { _mAINTENANCE_INTERVAL_MONTH = value; }
		}
	
		public string MAINTENANCE_INTERVAL_KM
		{
			get { return _mAINTENANCE_INTERVAL_KM; }
			set { _mAINTENANCE_INTERVAL_KM = value; }
		}
	
		public string VECHICLE_USER
		{
			get { return _vECHICLE_USER; }
			set { _vECHICLE_USER = value; }
		}
	
		public string BASE_STATION
		{
			get { return _bASE_STATION; }
			set { _bASE_STATION = value; }
		}
	
		public string VEHICLE_STATUS
		{
			get { return _vEHICLE_STATUS; }
			set { _vEHICLE_STATUS = value; }
		}
		
		#region Methods

        public VEHICLE()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	