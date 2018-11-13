using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

using DataAccess.Framework;
using DataHelper.Framework;
using Entity.Components;
using Entity.Framework;

namespace DataAccess.Components
{
    public class PagesDAO : DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public PagesDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.selectpages";
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
            Pages theEntity = new Pages();
            theEntity.ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
            theEntity.LINKNAME = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
            theEntity.PAGENAME = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
            theEntity.SUBMODULEID = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
            theEntity.BREADCRUMBS = !dr.IsDBNull(4) ? dr.GetValue(4).ToString() : string.Empty;
            theEntity.SHOWINMODULE = !dr.IsDBNull(5) ? dr.GetValue(5).ToString() : string.Empty;
            return theEntity;
        }
        protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            Pages theEntity = (Pages)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();

            if (!string.IsNullOrEmpty(theEntity.ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("p_id", theEntity.ID));
            if (!string.IsNullOrEmpty(theEntity.LINKNAME))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("p_linkname", theEntity.LINKNAME));
            if (!string.IsNullOrEmpty(theEntity.PAGENAME))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("p_pagename", theEntity.PAGENAME));
            if (!string.IsNullOrEmpty(theEntity.SUBMODULEID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("p_submoduleid", theEntity.SUBMODULEID));

            if (!string.IsNullOrEmpty(theEntity.BREADCRUMBS))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("p_BREADCRUMBS", theEntity.BREADCRUMBS));

            if (!string.IsNullOrEmpty(theEntity.SHOWINMODULE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("p_showinmodule", theEntity.SHOWINMODULE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
            return cmdParams.ToArray();
        }

        protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            Pages theEntity = (Pages)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("p_transmode", "i"));

            if (!string.IsNullOrEmpty(theEntity.ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("p_id", theEntity.ID));
            if (!string.IsNullOrEmpty(theEntity.LINKNAME))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("p_linkname", theEntity.LINKNAME));
            if (!string.IsNullOrEmpty(theEntity.PAGENAME))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("p_pagename", theEntity.PAGENAME));
            if (!string.IsNullOrEmpty(theEntity.SUBMODULEID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("p_submoduleid", theEntity.SUBMODULEID));

            if (!string.IsNullOrEmpty(theEntity.BREADCRUMBS))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("p_BREADCRUMBS", theEntity.BREADCRUMBS));

            if (!string.IsNullOrEmpty(theEntity.SHOWINMODULE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("p_showinmodule", theEntity.SHOWINMODULE));
            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
            return cmdParams.ToArray();
        }


        protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            Pages theEntity = (Pages)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("p_transmode", "u"));
            if (!string.IsNullOrEmpty(theEntity.ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("p_id", theEntity.ID));
            if (!string.IsNullOrEmpty(theEntity.LINKNAME))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("p_linkname", theEntity.LINKNAME));
            if (!string.IsNullOrEmpty(theEntity.PAGENAME))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("p_pagename", theEntity.PAGENAME));
            if (!string.IsNullOrEmpty(theEntity.SUBMODULEID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("p_submoduleid", theEntity.SUBMODULEID));

            if (!string.IsNullOrEmpty(theEntity.BREADCRUMBS))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("p_BREADCRUMBS", theEntity.BREADCRUMBS));

            if (!string.IsNullOrEmpty(theEntity.SHOWINMODULE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("p_showinmodule", theEntity.SHOWINMODULE));
            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
            return cmdParams.ToArray();
        }

        protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            Pages theEntity = (Pages)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("p_transmode", "d"));
            if (!string.IsNullOrEmpty(theEntity.ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("p_id", theEntity.ID));
            if (!string.IsNullOrEmpty(theEntity.LINKNAME))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("p_linkname", theEntity.LINKNAME));
            if (!string.IsNullOrEmpty(theEntity.PAGENAME))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("p_pagename", theEntity.PAGENAME));
            if (!string.IsNullOrEmpty(theEntity.SUBMODULEID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("p_submoduleid", theEntity.SUBMODULEID));

            if (!string.IsNullOrEmpty(theEntity.BREADCRUMBS))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("p_BREADCRUMBS", theEntity.BREADCRUMBS));

            if (!string.IsNullOrEmpty(theEntity.SHOWINMODULE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("p_showinmodule", theEntity.SHOWINMODULE));
            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
            return cmdParams.ToArray();
        }

        #endregion
    }
}