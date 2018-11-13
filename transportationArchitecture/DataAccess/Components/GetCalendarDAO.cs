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
    public class GetCalendarDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public GetCalendarDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_REPORTS.GETCALENDERSTARTDAY";
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
			GetCalendar theEntity = new GetCalendar();
	
			theEntity.DAYCOUNT = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.FIRSTDAY = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            GetCalendar theEntity = (GetCalendar)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("C_MONTH",theEntity.MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("C_YEAR",theEntity.YEAR));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            GetCalendar theEntity = (GetCalendar)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            GetCalendar theEntity = (GetCalendar)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            GetCalendar theEntity = (GetCalendar)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	