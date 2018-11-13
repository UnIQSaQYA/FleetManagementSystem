using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class PRODUCT_DEMAND : Entity.Framework.EntityBase
    {
        private string _pK_ID;
        private string _dEMAND_NO;
        private string _dEMAND_DAY;
        private string _dEMAND_MONTH;
        private string _dEMAND_YEAR;
        private string _dEMAND_DATE;
        private string _dEMAND_FISCALYEAR;
        private string _iNTERNAL_EXTERNAL;
        private string _dEMAND_OFFICE;
        private string _dEMAND_BY;
        private string _pURPOSE;
        private string _aPPROVE_BY;
        private string _aPPROVE_DAY;
        private string _aPPROVE_MONTH;
        private string _aPPROVE_YEAR;
        private string _aPPROVE_DATE;
        private string _eNTER_BY;
        private string _dEMAND_FULFILL_TYPE;
        private string _sTATUS;
        private string _oFFICE_CODE;


        public string OFFICE_CODE
        {
            get { return _oFFICE_CODE; }
            set { _oFFICE_CODE = value; }
        }
        public string PK_ID
        {
            get { return _pK_ID; }
            set { _pK_ID = value; }
        }

        public string DEMAND_NO
        {
            get { return _dEMAND_NO; }
            set { _dEMAND_NO = value; }
        }

        public string DEMAND_DAY
        {
            get { return _dEMAND_DAY; }
            set { _dEMAND_DAY = value; }
        }

        public string DEMAND_MONTH
        {
            get { return _dEMAND_MONTH; }
            set { _dEMAND_MONTH = value; }
        }

        public string DEMAND_YEAR
        {
            get { return _dEMAND_YEAR; }
            set { _dEMAND_YEAR = value; }
        }

        public string DEMAND_DATE
        {
            get { return _dEMAND_DATE; }
            set { _dEMAND_DATE = value; }
        }

        public string DEMAND_FISCALYEAR
        {
            get { return _dEMAND_FISCALYEAR; }
            set { _dEMAND_FISCALYEAR = value; }
        }

        public string INTERNAL_EXTERNAL
        {
            get { return _iNTERNAL_EXTERNAL; }
            set { _iNTERNAL_EXTERNAL = value; }
        }

        public string DEMAND_OFFICE
        {
            get { return _dEMAND_OFFICE; }
            set { _dEMAND_OFFICE = value; }
        }

        public string DEMAND_BY
        {
            get { return _dEMAND_BY; }
            set { _dEMAND_BY = value; }
        }

        public string PURPOSE
        {
            get { return _pURPOSE; }
            set { _pURPOSE = value; }
        }

        public string APPROVE_BY
        {
            get { return _aPPROVE_BY; }
            set { _aPPROVE_BY = value; }
        }

        public string APPROVE_DAY
        {
            get { return _aPPROVE_DAY; }
            set { _aPPROVE_DAY = value; }
        }

        public string APPROVE_MONTH
        {
            get { return _aPPROVE_MONTH; }
            set { _aPPROVE_MONTH = value; }
        }

        public string APPROVE_YEAR
        {
            get { return _aPPROVE_YEAR; }
            set { _aPPROVE_YEAR = value; }
        }

        public string APPROVE_DATE
        {
            get { return _aPPROVE_DATE; }
            set { _aPPROVE_DATE = value; }
        }

        public string ENTER_BY
        {
            get { return _eNTER_BY; }
            set { _eNTER_BY = value; }
        }

        public string DEMAND_FULFILL_TYPE
        {
            get { return _dEMAND_FULFILL_TYPE; }
            set { _dEMAND_FULFILL_TYPE = value; }
        }

        public string STATUS
        {
            get { return _sTATUS; }
            set { _sTATUS = value; }
        }

        #region Methods

        public PRODUCT_DEMAND()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
