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
    public class FIVE_DIMENSION_TEMPDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public FIVE_DIMENSION_TEMPDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTFIVE_DIMENSION_TEMP";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYFIVE_DIMENSION_TEMP";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYFIVE_DIMENSION_TEMP";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYFIVE_DIMENSION_TEMP";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			FIVE_DIMENSION_TEMP theEntity = new FIVE_DIMENSION_TEMP();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.VEHICLE_ID = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.DIMENSION = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.SCRATCH = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			theEntity.MISSING = !dr.IsDBNull(4) ? dr.GetValue(4).ToString() : string.Empty;
	
			theEntity.BROKEN = !dr.IsDBNull(5) ? dr.GetValue(5).ToString() : string.Empty;
	
			theEntity.DENTED = !dr.IsDBNull(6) ? dr.GetValue(6).ToString() : string.Empty;
	
			theEntity.OTHERS = !dr.IsDBNull(7) ? dr.GetValue(7).ToString() : string.Empty;
	
			theEntity.OTHER_DESCRIPTION = !dr.IsDBNull(8) ? dr.GetValue(8).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            FIVE_DIMENSION_TEMP theEntity = (FIVE_DIMENSION_TEMP)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));

            if (!string.IsNullOrEmpty(theEntity.VEHICLE_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_ID", theEntity.VEHICLE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DIMENSION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DIMENSION",theEntity.DIMENSION));
	
			if(!string.IsNullOrEmpty(theEntity.SCRATCH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SCRATCH",theEntity.SCRATCH));
	
			if(!string.IsNullOrEmpty(theEntity.MISSING))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MISSING",theEntity.MISSING));
	
			if(!string.IsNullOrEmpty(theEntity.BROKEN))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_BROKEN",theEntity.BROKEN));
	
			if(!string.IsNullOrEmpty(theEntity.DENTED))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DENTED",theEntity.DENTED));
	
			if(!string.IsNullOrEmpty(theEntity.OTHERS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OTHERS",theEntity.OTHERS));
	
			if(!string.IsNullOrEmpty(theEntity.OTHER_DESCRIPTION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OTHER_DESCRIPTION",theEntity.OTHER_DESCRIPTION));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            FIVE_DIMENSION_TEMP theEntity = (FIVE_DIMENSION_TEMP)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));

            if (!string.IsNullOrEmpty(theEntity.VEHICLE_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_ID", theEntity.VEHICLE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DIMENSION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DIMENSION",theEntity.DIMENSION));
	
			if(!string.IsNullOrEmpty(theEntity.SCRATCH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SCRATCH",theEntity.SCRATCH));
	
			if(!string.IsNullOrEmpty(theEntity.MISSING))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MISSING",theEntity.MISSING));
	
			if(!string.IsNullOrEmpty(theEntity.BROKEN))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_BROKEN",theEntity.BROKEN));
	
			if(!string.IsNullOrEmpty(theEntity.DENTED))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DENTED",theEntity.DENTED));
	
			if(!string.IsNullOrEmpty(theEntity.OTHERS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OTHERS",theEntity.OTHERS));
	
			if(!string.IsNullOrEmpty(theEntity.OTHER_DESCRIPTION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OTHER_DESCRIPTION",theEntity.OTHER_DESCRIPTION));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            FIVE_DIMENSION_TEMP theEntity = (FIVE_DIMENSION_TEMP)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));

            if (!string.IsNullOrEmpty(theEntity.VEHICLE_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_ID", theEntity.VEHICLE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DIMENSION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DIMENSION",theEntity.DIMENSION));
	
			if(!string.IsNullOrEmpty(theEntity.SCRATCH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SCRATCH",theEntity.SCRATCH));
	
			if(!string.IsNullOrEmpty(theEntity.MISSING))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MISSING",theEntity.MISSING));
	
			if(!string.IsNullOrEmpty(theEntity.BROKEN))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_BROKEN",theEntity.BROKEN));
	
			if(!string.IsNullOrEmpty(theEntity.DENTED))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DENTED",theEntity.DENTED));
	
			if(!string.IsNullOrEmpty(theEntity.OTHERS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OTHERS",theEntity.OTHERS));
	
			if(!string.IsNullOrEmpty(theEntity.OTHER_DESCRIPTION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OTHER_DESCRIPTION",theEntity.OTHER_DESCRIPTION));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            FIVE_DIMENSION_TEMP theEntity = (FIVE_DIMENSION_TEMP)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));

            if (!string.IsNullOrEmpty(theEntity.VEHICLE_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_ID", theEntity.VEHICLE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DIMENSION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DIMENSION",theEntity.DIMENSION));
	
			if(!string.IsNullOrEmpty(theEntity.SCRATCH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SCRATCH",theEntity.SCRATCH));
	
			if(!string.IsNullOrEmpty(theEntity.MISSING))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MISSING",theEntity.MISSING));
	
			if(!string.IsNullOrEmpty(theEntity.BROKEN))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_BROKEN",theEntity.BROKEN));
	
			if(!string.IsNullOrEmpty(theEntity.DENTED))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DENTED",theEntity.DENTED));
	
			if(!string.IsNullOrEmpty(theEntity.OTHERS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OTHERS",theEntity.OTHERS));
	
			if(!string.IsNullOrEmpty(theEntity.OTHER_DESCRIPTION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OTHER_DESCRIPTION",theEntity.OTHER_DESCRIPTION));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	