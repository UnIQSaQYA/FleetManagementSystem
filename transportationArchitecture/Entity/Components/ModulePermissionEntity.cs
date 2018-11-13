using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Components
{
    public class ModulePermissionEntity : Entity.Framework.EntityBase
    {
        private string _moduleid;
        private string _modulename;
        private string _picturename;
        private string _remarks;
        
        public string Moduleid
        {
            get { return _moduleid; }
            set { _moduleid = value;  }
        }
        public string Modulename
        {
            get { return _modulename; }
            set { _modulename = value; }
        }
        public string Picturename
        {
            get { return _picturename; }
            set { _picturename = value; }
        }
        public string Remarks 
        {
            get { return _remarks; }
            set { _remarks = value; }
        }
       

        #region Methods

        public ModulePermissionEntity()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
