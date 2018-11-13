using System;
using System.Collections.Generic;
using System.Text;
using NCCSEncryption;


namespace Entity.Components
{
   public class UserPageAccess
    {
        Boolean _full = false;
        Boolean _read = false;
        Boolean _write = false;
        Boolean _modify = false;
        Boolean _delete = false;
        Boolean _aChecker = false;
        Boolean _aApprover = false;
        Boolean _aPasser = false;


        public Boolean Full
        {
            get { return _full; }
        }

        public Boolean Read
        {
            get { return _read; }
        }

        public Boolean Write
        {
            get { return _write; }
        }

        public Boolean Modify
        {
            get { return _modify; }
        }

        public Boolean Delete
        {
            get { return _delete; }
        }

        public Boolean AChecker
        {
            get { return _aChecker; }
        }

        public Boolean AApprover
        {
            get { return _aApprover; }
        }

        public Boolean APasser
        {
            get { return _aPasser; }
        }

        public void SetProperties(string strQString)
        {
            string Role = "";
            string AccountAccess = "";
            string AccessCode = "";
            Encryption MyEncr = new Encryption();
            string QString = strQString;
            QString = QString.Replace("%2f", @"/");
            QString = QString.Replace("%3d", @"=");
            QString = MyEncr.Decrypt(QString, "!#$a54?3");
            string[] QStringArr = QString.Split('&');
            try
            {
                Role = QStringArr[1].ToString().Split('=')[1].ToString();
                AccessCode = QStringArr[0].ToString().Split('=')[1].ToString();
                AccountAccess = QStringArr[2].ToString().Split('=')[1].ToString();
            }
            catch
            {

            }

            if (Role=="Full")
            {
                _full = true;
                _read = true;
                _write = true;
                _modify = true;
                _delete = true;
            }
            else if (Role=="AddModifyView")
            {
                _full = false;
                _read = true;
                _write = true;
                _modify = true;
                _delete = false;
            }
            else if (Role=="AddViewDelete")
            {
                _full = false;
                _read = true;
                _write = true;
                _modify = false;
                _delete = true;
            }
            else if (Role=="ViewModifyDelete")
            {
                 _full = false;
                _read = true;
                _write = false;
                _modify = true;
                _delete = true;
            }
            else if (Role=="AddModifyDelete")
            {
                _full = false;
                _read = false;
                _write = true;
                _modify = true;
                _delete = true;
            }
            else if (Role=="ModifyDelete")
            {
                _full = false;
                _read = false;
                _write = false;
                _modify = true;
                _delete = true;
            }
            else if (Role=="AddDelete")
            {
                _full = false;
                _read = false;
                _write = true;
                _modify = false;
                _delete = true;
            }
            else if (Role=="AddModify")
            {
                _full = false;
                _read = false;
                _write = true;
                _modify = true;
                _delete = false;
            }
            else if (Role=="ViewAdd")
            {
                _full = false;
                _read = true;
                _write = true;
                _modify = false;
                _delete = false;
            }
            else if (Role=="ViewDelete")
            {
                _full = false;
                _read = true;
                _write = false;
                _modify = false;
                _delete = true;
            }
            else if (Role=="ModifyView")
            {
                _full = false;
                _read = true;
                _write = false;
                _modify = true;
                _delete = false;
            }
            else if (Role=="Delete")
            {
                _full = false;
                _read = false;
                _write = false;
                _modify = false;
                _delete = true;
            }
            else if (Role=="ModifyView")
            {
                _full = false;
                _read = true;
                _write = false;
                _modify = true;
                _delete = false;
            }
            else if (Role=="Add")
            {
                _full = false;
                _read = false;
                _write = true;
                _modify = false;
                _delete = false;
            }
            else if (Role=="View")
            {
                _full = false;
                _read = true;
                _write = false;
                _modify = false;
                _delete = false;
            }
            else if (Role=="NoAccess")
            {
                _full = false;
                _read = false;
                _write = false;
                _modify = false;
                _delete = false;
            }

            if (AccountAccess == "VCheckerPasserApprover")
            {
                _aChecker = true;
                _aApprover = true;
                _aPasser = true;
            }
            else if (AccountAccess == "VPasserApprover")
            {
                _aPasser = true;
                _aApprover = true;
                _aChecker = false;
            }
            else if (AccountAccess == "VCheckerPasser")
            {
                _aPasser = true;
                _aApprover = false;
                _aChecker = true;
            }
            else if (AccountAccess == "VApprover")
            {
                _aPasser = false;
                _aApprover = true;
                _aChecker = false;
            }
            else if (AccountAccess == "VPasser")
            {
                _aPasser = true;
                _aApprover = false;
                _aChecker = false;
            }
            else if (AccountAccess == "VChecker")
            {
                _aPasser = false;
                _aApprover = false;
                _aChecker = true;
            }
            else if (AccountAccess=="NoAccess")
            {
                _aPasser = false;
                _aApprover = false;
                _aChecker = false;
            }
        }
    }
}
