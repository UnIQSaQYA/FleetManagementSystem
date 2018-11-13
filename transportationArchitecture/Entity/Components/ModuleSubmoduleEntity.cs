using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Components
{
    public class ModuleSubmoduleEntity : Entity.Framework.EntityBase
    {

        #region Enum
        public enum UserRights { Full = 1, AddModifyDelete, AddModifyView, AddViewDelete, ViewModifyDelete, AddModify, AddDelete, AddView, ModifyDelete, ModifyView, ViewAdd, ViewDelete, Add, Delete, Modify, View, NoAccess,VCreator,VApprover,VViewer,VCreatorApproverViewer,VCreatorApprover,VCreatorViewer,VApproverViewer };
        #endregion

        private int _moduleid;
        private string _modulename;
        private int _leafnode;
        private int _parentmodule;
        private int _submoduleid;
        private string _name;
        private string _permission;
        private string _picturename;
        private string _remarks;
        private string _orderid;
        private UserRights _Role;
        private UserRights _AccountAccess;
      
        
        
        public int Moduleid
        {
            get { return _moduleid; }
            set { _moduleid = value;  }
        }
        public string Modulename
        {
            get { return _modulename; }
            set { _modulename = value; }
        }
        public int Leafnode
        {
            get { return _leafnode; }
            set { _leafnode = value; }
        }
        public int Parentmodule 
        {
            get { return _parentmodule; }
            set { _parentmodule = value; }
        }

        public int Submoduleid
        {
            get { return _submoduleid; }
            set { _submoduleid = value; }
        }
        public string Name 
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Permission 
        {
            get { return _permission; }
            set { _permission = value; }
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

        public string Orderid
        {
            get { return _orderid; }
            set { _orderid = value; }
        }

        public UserRights Role
        {
            get { return _Role ; }
            set { _Role = value; }
        }

        public UserRights AccountAccess
        {
            get { return _AccountAccess; }
            set { _AccountAccess = value; }
        }

        #region Methods

        public ModuleSubmoduleEntity()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
