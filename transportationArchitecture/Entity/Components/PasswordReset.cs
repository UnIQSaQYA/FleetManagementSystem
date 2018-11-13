using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class PasswordReset : Entity.Framework.EntityBase
    {

        private string _eMPLOYEE_ID;
        private string _cONFIRMATION_CODE;


       

        public string EMPLOYEE_ID
        {
            get { return _eMPLOYEE_ID; }
            set { _eMPLOYEE_ID = value; }
        }
       
        public string CONFIRMATION_CODE
{
  get { return _cONFIRMATION_CODE; }
  set { _cONFIRMATION_CODE = value; }
}
      



       
        

       
        #region Methods

        public PasswordReset()
            : base(string.Empty)
        {
        }
        #endregion
    }
}