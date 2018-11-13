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
    public class PERSONDETAILSDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public PERSONDETAILSDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTPERSONDETAILS";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYPERSONDETAILS";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYPERSONDETAILS";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYPERSONDETAILS";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			PERSONDETAILS theEntity = new PERSONDETAILS();
	
			theEntity.CODE = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.NAME = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.FATHER_NAME = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.GRAND_FATHER_NAME = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			theEntity.RNK = !dr.IsDBNull(4) ? dr.GetValue(4).ToString() : string.Empty;
	
			theEntity.PIS = !dr.IsDBNull(5) ? dr.GetValue(5).ToString() : string.Empty;
	
			theEntity.POSITION = !dr.IsDBNull(6) ? dr.GetValue(6).ToString() : string.Empty;
	
			theEntity.ADDRESS = !dr.IsDBNull(7) ? dr.GetValue(7).ToString() : string.Empty;
	
			theEntity.MOJ = !dr.IsDBNull(8) ? dr.GetValue(8).ToString() : string.Empty;
	
			theEntity.MOR = !dr.IsDBNull(9) ? dr.GetValue(9).ToString() : string.Empty;
	
			theEntity.CURRENT_UNIT = !dr.IsDBNull(10) ? dr.GetValue(10).ToString() : string.Empty;
	
			theEntity.JOB_STATUS = !dr.IsDBNull(11) ? dr.GetValue(11).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            PERSONDETAILS theEntity = (PERSONDETAILS)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CODE",theEntity.CODE));
	
			if(!string.IsNullOrEmpty(theEntity.NAME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_NAME",theEntity.NAME));
	
			if(!string.IsNullOrEmpty(theEntity.FATHER_NAME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FATHER_NAME",theEntity.FATHER_NAME));
	
			if(!string.IsNullOrEmpty(theEntity.GRAND_FATHER_NAME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_GRAND_FATHER_NAME",theEntity.GRAND_FATHER_NAME));
	
			if(!string.IsNullOrEmpty(theEntity.RNK))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RNK",theEntity.RNK));
	
			if(!string.IsNullOrEmpty(theEntity.PIS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PIS",theEntity.PIS));
	
			if(!string.IsNullOrEmpty(theEntity.POSITION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_POSITION",theEntity.POSITION));
	
			if(!string.IsNullOrEmpty(theEntity.ADDRESS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ADDRESS",theEntity.ADDRESS));
	
			if(!string.IsNullOrEmpty(theEntity.MOJ))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MOJ",theEntity.MOJ));
	
			if(!string.IsNullOrEmpty(theEntity.MOR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MOR",theEntity.MOR));
	
			if(!string.IsNullOrEmpty(theEntity.CURRENT_UNIT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CURRENT_UNIT",theEntity.CURRENT_UNIT));
	
			if(!string.IsNullOrEmpty(theEntity.JOB_STATUS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_JOB_STATUS",theEntity.JOB_STATUS));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            PERSONDETAILS theEntity = (PERSONDETAILS)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CODE",theEntity.CODE));
	
			if(!string.IsNullOrEmpty(theEntity.NAME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_NAME",theEntity.NAME));
	
			if(!string.IsNullOrEmpty(theEntity.FATHER_NAME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FATHER_NAME",theEntity.FATHER_NAME));
	
			if(!string.IsNullOrEmpty(theEntity.GRAND_FATHER_NAME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_GRAND_FATHER_NAME",theEntity.GRAND_FATHER_NAME));
	
			if(!string.IsNullOrEmpty(theEntity.RNK))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RNK",theEntity.RNK));
	
			if(!string.IsNullOrEmpty(theEntity.PIS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PIS",theEntity.PIS));
	
			if(!string.IsNullOrEmpty(theEntity.POSITION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_POSITION",theEntity.POSITION));
	
			if(!string.IsNullOrEmpty(theEntity.ADDRESS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ADDRESS",theEntity.ADDRESS));
	
			if(!string.IsNullOrEmpty(theEntity.MOJ))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MOJ",theEntity.MOJ));
	
			if(!string.IsNullOrEmpty(theEntity.MOR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MOR",theEntity.MOR));
	
			if(!string.IsNullOrEmpty(theEntity.CURRENT_UNIT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CURRENT_UNIT",theEntity.CURRENT_UNIT));
	
			if(!string.IsNullOrEmpty(theEntity.JOB_STATUS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_JOB_STATUS",theEntity.JOB_STATUS));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            PERSONDETAILS theEntity = (PERSONDETAILS)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CODE",theEntity.CODE));
	
			if(!string.IsNullOrEmpty(theEntity.NAME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_NAME",theEntity.NAME));
	
			if(!string.IsNullOrEmpty(theEntity.FATHER_NAME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FATHER_NAME",theEntity.FATHER_NAME));
	
			if(!string.IsNullOrEmpty(theEntity.GRAND_FATHER_NAME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_GRAND_FATHER_NAME",theEntity.GRAND_FATHER_NAME));
	
			if(!string.IsNullOrEmpty(theEntity.RNK))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RNK",theEntity.RNK));
	
			if(!string.IsNullOrEmpty(theEntity.PIS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PIS",theEntity.PIS));
	
			if(!string.IsNullOrEmpty(theEntity.POSITION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_POSITION",theEntity.POSITION));
	
			if(!string.IsNullOrEmpty(theEntity.ADDRESS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ADDRESS",theEntity.ADDRESS));
	
			if(!string.IsNullOrEmpty(theEntity.MOJ))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MOJ",theEntity.MOJ));
	
			if(!string.IsNullOrEmpty(theEntity.MOR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MOR",theEntity.MOR));
	
			if(!string.IsNullOrEmpty(theEntity.CURRENT_UNIT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CURRENT_UNIT",theEntity.CURRENT_UNIT));
	
			if(!string.IsNullOrEmpty(theEntity.JOB_STATUS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_JOB_STATUS",theEntity.JOB_STATUS));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            PERSONDETAILS theEntity = (PERSONDETAILS)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CODE",theEntity.CODE));
	
			if(!string.IsNullOrEmpty(theEntity.NAME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_NAME",theEntity.NAME));
	
			if(!string.IsNullOrEmpty(theEntity.FATHER_NAME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FATHER_NAME",theEntity.FATHER_NAME));
	
			if(!string.IsNullOrEmpty(theEntity.GRAND_FATHER_NAME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_GRAND_FATHER_NAME",theEntity.GRAND_FATHER_NAME));
	
			if(!string.IsNullOrEmpty(theEntity.RNK))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RNK",theEntity.RNK));
	
			if(!string.IsNullOrEmpty(theEntity.PIS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PIS",theEntity.PIS));
	
			if(!string.IsNullOrEmpty(theEntity.POSITION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_POSITION",theEntity.POSITION));
	
			if(!string.IsNullOrEmpty(theEntity.ADDRESS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ADDRESS",theEntity.ADDRESS));
	
			if(!string.IsNullOrEmpty(theEntity.MOJ))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MOJ",theEntity.MOJ));
	
			if(!string.IsNullOrEmpty(theEntity.MOR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MOR",theEntity.MOR));
	
			if(!string.IsNullOrEmpty(theEntity.CURRENT_UNIT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CURRENT_UNIT",theEntity.CURRENT_UNIT));
	
			if(!string.IsNullOrEmpty(theEntity.JOB_STATUS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_JOB_STATUS",theEntity.JOB_STATUS));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	