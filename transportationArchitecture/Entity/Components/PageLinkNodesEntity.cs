using System;
using System.Collections.Generic;
using System.Text;


namespace Entity.Components
{
    public class PageLinkNodesEntity : Entity.Framework.EntityBase
    {

        #region Enum
        public enum UserRights { 
            Full = 1, 
            AddModifyDelete, 
            AddModifyView, 
            AddViewDelete, 
            ViewModifyDelete, 
            AddModify, 
            AddDelete, 
            AddView, 
            ModifyDelete, 
            ModifyView, 
            ViewAdd, 
            ViewDelete, 
            Add, 
            Delete, 
            Modify, 
            View, 
            NoAccess, 
            VChecker, 
            VApprover, 
            VPasser, 
            VCheckerPasserApprover,
            VPasserApprover,
            VCheckerPasser

        };
        #endregion
        
        private UserRights _Role;
        private UserRights _AccountAccess;
        private int _submoduleid;
        private string _pagename;
        private string _linkUrl;
        private string _pageID;
        private string _Permission;



        public int Submoduleid
        {
            get { return _submoduleid; }
            set { _submoduleid = value; }
        }
        public string pageID
        {
            get { return _pageID; }
            set { _pageID = value; }
        }
        public string Pagename
        {
            get { return _pagename; }
            set { _pagename = value; }
        }

        public string LinkUrl
        {
            get { return _linkUrl; }
            set { _linkUrl = value; }
        }

        public string Permission
        {
            get { return _Permission; }
            set { _Permission = value; }
        }

        public UserRights Role
        {
            get { return _Role; }
            set { _Role = value; }
        }

        public UserRights AccountAccess
        {
            get { return _AccountAccess; }
            set { _AccountAccess = value; }
        }

        #region Methods

        public PageLinkNodesEntity()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
