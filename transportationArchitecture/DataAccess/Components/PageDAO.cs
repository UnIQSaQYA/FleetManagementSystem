using System;
using System.Collections.Generic;
using System.Data;


using System.Text;

using DataAccess.Framework;
using DataHelper.Framework;
using Entity.Components;
using Entity.Framework;
using System.Collections;

namespace DataAccess.Components
{
    public class PageDAO : DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public PageDAO()
        {

        }
        #endregion

        #region Override Properties

        protected string GetModuleSubModules
        {
            get
            {
                return "PKJ_UserAcces.getPageName";
            }
        }
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_UserAcces.getPageName";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "";
            }
        }
        #endregion

        #region Overridden Methods

        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
            PageLinkNodesEntity theEntity = new PageLinkNodesEntity();

            theEntity.Pagename= !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;

            theEntity.LinkUrl = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;

            theEntity.Submoduleid = !dr.IsDBNull(2) ? Int32.Parse(dr.GetValue(2).ToString()) : -1;

            return theEntity;
        }
        protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            PageLinkNodesEntity theEntity = (PageLinkNodesEntity)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();

            if (!string.IsNullOrEmpty(theEntity.Submoduleid.ToString()))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("Page_id", theEntity.pageID));

            if (!string.IsNullOrEmpty(theEntity.Pagename))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("Link_name", theEntity.Pagename));

            if (!string.IsNullOrEmpty(theEntity.LinkUrl))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("Page_name", theEntity.LinkUrl));

            // This is the output parameter that is required for Oracle Connection. 
            // This is required only when the database is oracle as it will return curson.

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));

            return cmdParams.ToArray();
        }

        protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            return null;
        }

        protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            return null;
        }

        protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            return null;
        }

        #endregion
            

        public EntityList GetLinkNodes(EntityBase anEntity)
        {
            IDbDataParameter[] cmdParams = this.CreateSelectParameters(anEntity);
            return GetList(GetModuleSubModules, this.CommandTypeUsed, cmdParams);
        }
    }
}
