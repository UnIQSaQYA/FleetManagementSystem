using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class VW_ORGH : Entity.Framework.EntityBase
    {
		private string _oRG_STRUCTURE_CODE;
		private string _oRG_STRUCTURE_NAME;
		private string _oRG_STRUCTURE_NAME_DEVNAGARI;
		private string _uPPER_ORG_STRUCTURE_CODE;
		private string _hIERARCHY_NAME;
		private string _aDDRESS;
		private string _lOCATION_CODE;
		private string _tELEPHONE_NO;
		private string _gRADE_CODE;
		private string _oRG_UNIT_TYPE;
		private string _eFFECTIVE_DATE_AD;
		private string _eFFECTIVE_DATE_BS;
		private string _cOLLAPSE_DATE_AD;
		private string _cOLLAPSE_DATE_BS;
		private string _dESCRIPTION;
		private string _oRDER_DATE_AD;
		private string _oRDER_DATE_BS;
		private string _oRDER_NO;
		private string _aUTHORISED_BY;
		private string _aUTHORISED_POSITION_CODE;
		private string _aUTHORISED_ORGANIZATION_CODE;
		private string _pREPARED_ON;
		private string _pREPARED_BY;
		private string _dARBANDI_DEFINED_AS;
		private string _oRG_TYPE_CODE;
	
		public string ORG_STRUCTURE_CODE
		{
			get { return _oRG_STRUCTURE_CODE; }
			set { _oRG_STRUCTURE_CODE = value; }
		}
	
		public string ORG_STRUCTURE_NAME
		{
			get { return _oRG_STRUCTURE_NAME; }
			set { _oRG_STRUCTURE_NAME = value; }
		}
	
		public string ORG_STRUCTURE_NAME_DEVNAGARI
		{
			get { return _oRG_STRUCTURE_NAME_DEVNAGARI; }
			set { _oRG_STRUCTURE_NAME_DEVNAGARI = value; }
		}
	
		public string UPPER_ORG_STRUCTURE_CODE
		{
			get { return _uPPER_ORG_STRUCTURE_CODE; }
			set { _uPPER_ORG_STRUCTURE_CODE = value; }
		}
	
		public string HIERARCHY_NAME
		{
			get { return _hIERARCHY_NAME; }
			set { _hIERARCHY_NAME = value; }
		}
	
		public string ADDRESS
		{
			get { return _aDDRESS; }
			set { _aDDRESS = value; }
		}
	
		public string LOCATION_CODE
		{
			get { return _lOCATION_CODE; }
			set { _lOCATION_CODE = value; }
		}
	
		public string TELEPHONE_NO
		{
			get { return _tELEPHONE_NO; }
			set { _tELEPHONE_NO = value; }
		}
	
		public string GRADE_CODE
		{
			get { return _gRADE_CODE; }
			set { _gRADE_CODE = value; }
		}
	
		public string ORG_UNIT_TYPE
		{
			get { return _oRG_UNIT_TYPE; }
			set { _oRG_UNIT_TYPE = value; }
		}
	
		public string EFFECTIVE_DATE_AD
		{
			get { return _eFFECTIVE_DATE_AD; }
			set { _eFFECTIVE_DATE_AD = value; }
		}
	
		public string EFFECTIVE_DATE_BS
		{
			get { return _eFFECTIVE_DATE_BS; }
			set { _eFFECTIVE_DATE_BS = value; }
		}
	
		public string COLLAPSE_DATE_AD
		{
			get { return _cOLLAPSE_DATE_AD; }
			set { _cOLLAPSE_DATE_AD = value; }
		}
	
		public string COLLAPSE_DATE_BS
		{
			get { return _cOLLAPSE_DATE_BS; }
			set { _cOLLAPSE_DATE_BS = value; }
		}
	
		public string DESCRIPTION
		{
			get { return _dESCRIPTION; }
			set { _dESCRIPTION = value; }
		}
	
		public string ORDER_DATE_AD
		{
			get { return _oRDER_DATE_AD; }
			set { _oRDER_DATE_AD = value; }
		}
	
		public string ORDER_DATE_BS
		{
			get { return _oRDER_DATE_BS; }
			set { _oRDER_DATE_BS = value; }
		}
	
		public string ORDER_NO
		{
			get { return _oRDER_NO; }
			set { _oRDER_NO = value; }
		}
	
		public string AUTHORISED_BY
		{
			get { return _aUTHORISED_BY; }
			set { _aUTHORISED_BY = value; }
		}
	
		public string AUTHORISED_POSITION_CODE
		{
			get { return _aUTHORISED_POSITION_CODE; }
			set { _aUTHORISED_POSITION_CODE = value; }
		}
	
		public string AUTHORISED_ORGANIZATION_CODE
		{
			get { return _aUTHORISED_ORGANIZATION_CODE; }
			set { _aUTHORISED_ORGANIZATION_CODE = value; }
		}
	
		public string PREPARED_ON
		{
			get { return _pREPARED_ON; }
			set { _pREPARED_ON = value; }
		}
	
		public string PREPARED_BY
		{
			get { return _pREPARED_BY; }
			set { _pREPARED_BY = value; }
		}
	
		public string DARBANDI_DEFINED_AS
		{
			get { return _dARBANDI_DEFINED_AS; }
			set { _dARBANDI_DEFINED_AS = value; }
		}
	
		public string ORG_TYPE_CODE
		{
			get { return _oRG_TYPE_CODE; }
			set { _oRG_TYPE_CODE = value; }
		}
		
		#region Methods

        public VW_ORGH()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	