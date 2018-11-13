using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class Pages : Entity.Framework.EntityBase
    {
        private string _ID;
        private string _LINKNAME;
        private string _PAGENAME;
        private string _SUBMODULEID;
        private string _BREADCRUMBS;
        private string _SHOWINMODULE;

        public string SHOWINMODULE
        {
            get { return _SHOWINMODULE; }
            set { _SHOWINMODULE = value; }
        }

        public string BREADCRUMBS
        {
            get { return _BREADCRUMBS; }
            set { _BREADCRUMBS = value; }
        }
        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public string LINKNAME
        {
            get { return _LINKNAME; }
            set { _LINKNAME = value; }
        }
        public string PAGENAME
        {
            get { return _PAGENAME; }
            set { _PAGENAME = value; }
        }
        public string SUBMODULEID
        {
            get { return _SUBMODULEID; }
            set { _SUBMODULEID = value; }
        }
        #region Methods

        public Pages()
            : base(string.Empty)
        {
        }
        #endregion
    }
}