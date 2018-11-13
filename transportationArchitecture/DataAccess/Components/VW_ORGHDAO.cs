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
    public class VW_ORGHDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public VW_ORGHDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTVW_ORGH";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYVW_ORGH";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYVW_ORGH";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYVW_ORGH";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			VW_ORGH theEntity = new VW_ORGH();
	
			theEntity.ORG_STRUCTURE_CODE = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.ORG_STRUCTURE_NAME = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.ORG_STRUCTURE_NAME_DEVNAGARI = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.UPPER_ORG_STRUCTURE_CODE = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			theEntity.HIERARCHY_NAME = !dr.IsDBNull(4) ? dr.GetValue(4).ToString() : string.Empty;
	
			theEntity.ADDRESS = !dr.IsDBNull(5) ? dr.GetValue(5).ToString() : string.Empty;
	
			theEntity.LOCATION_CODE = !dr.IsDBNull(6) ? dr.GetValue(6).ToString() : string.Empty;
	
			theEntity.TELEPHONE_NO = !dr.IsDBNull(7) ? dr.GetValue(7).ToString() : string.Empty;
	
			theEntity.GRADE_CODE = !dr.IsDBNull(8) ? dr.GetValue(8).ToString() : string.Empty;
	
			theEntity.ORG_UNIT_TYPE = !dr.IsDBNull(9) ? dr.GetValue(9).ToString() : string.Empty;
	
			theEntity.EFFECTIVE_DATE_AD = !dr.IsDBNull(10) ? dr.GetValue(10).ToString() : string.Empty;
	
			theEntity.EFFECTIVE_DATE_BS = !dr.IsDBNull(11) ? dr.GetValue(11).ToString() : string.Empty;
	
			theEntity.COLLAPSE_DATE_AD = !dr.IsDBNull(12) ? dr.GetValue(12).ToString() : string.Empty;
	
			theEntity.COLLAPSE_DATE_BS = !dr.IsDBNull(13) ? dr.GetValue(13).ToString() : string.Empty;
	
			theEntity.DESCRIPTION = !dr.IsDBNull(14) ? dr.GetValue(14).ToString() : string.Empty;
	
			theEntity.ORDER_DATE_AD = !dr.IsDBNull(15) ? dr.GetValue(15).ToString() : string.Empty;
	
			theEntity.ORDER_DATE_BS = !dr.IsDBNull(16) ? dr.GetValue(16).ToString() : string.Empty;
	
			theEntity.ORDER_NO = !dr.IsDBNull(17) ? dr.GetValue(17).ToString() : string.Empty;
	
			theEntity.AUTHORISED_BY = !dr.IsDBNull(18) ? dr.GetValue(18).ToString() : string.Empty;
	
			theEntity.AUTHORISED_POSITION_CODE = !dr.IsDBNull(19) ? dr.GetValue(19).ToString() : string.Empty;
	
			theEntity.AUTHORISED_ORGANIZATION_CODE = !dr.IsDBNull(20) ? dr.GetValue(20).ToString() : string.Empty;
	
			theEntity.PREPARED_ON = !dr.IsDBNull(21) ? dr.GetValue(21).ToString() : string.Empty;
	
			theEntity.PREPARED_BY = !dr.IsDBNull(22) ? dr.GetValue(22).ToString() : string.Empty;
	
			theEntity.DARBANDI_DEFINED_AS = !dr.IsDBNull(23) ? dr.GetValue(23).ToString() : string.Empty;
	
			theEntity.ORG_TYPE_CODE = !dr.IsDBNull(24) ? dr.GetValue(24).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            VW_ORGH theEntity = (VW_ORGH)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.ORG_STRUCTURE_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORG_STRUCTURE_CODE",theEntity.ORG_STRUCTURE_CODE));
	
			if(!string.IsNullOrEmpty(theEntity.ORG_STRUCTURE_NAME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORG_STRUCTURE_NAME",theEntity.ORG_STRUCTURE_NAME));
	
			if(!string.IsNullOrEmpty(theEntity.ORG_STRUCTURE_NAME_DEVNAGARI))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORG_STRUCTURE_NAME_DEV",theEntity.ORG_STRUCTURE_NAME_DEVNAGARI));
	
			if(!string.IsNullOrEmpty(theEntity.UPPER_ORG_STRUCTURE_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_UPPER_ORG_STRUCTURE_CODE",theEntity.UPPER_ORG_STRUCTURE_CODE));
	
			if(!string.IsNullOrEmpty(theEntity.HIERARCHY_NAME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_HIERARCHY_NAME",theEntity.HIERARCHY_NAME));
	
			if(!string.IsNullOrEmpty(theEntity.ADDRESS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ADDRESS",theEntity.ADDRESS));
	
			if(!string.IsNullOrEmpty(theEntity.LOCATION_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_LOCATION_CODE",theEntity.LOCATION_CODE));
	
			if(!string.IsNullOrEmpty(theEntity.TELEPHONE_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TELEPHONE_NO",theEntity.TELEPHONE_NO));
	
			if(!string.IsNullOrEmpty(theEntity.GRADE_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_GRADE_CODE",theEntity.GRADE_CODE));
	
			if(!string.IsNullOrEmpty(theEntity.ORG_UNIT_TYPE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORG_UNIT_TYPE",theEntity.ORG_UNIT_TYPE));
	
			if(!string.IsNullOrEmpty(theEntity.EFFECTIVE_DATE_AD))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_EFFECTIVE_DATE_AD",theEntity.EFFECTIVE_DATE_AD));
	
			if(!string.IsNullOrEmpty(theEntity.EFFECTIVE_DATE_BS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_EFFECTIVE_DATE_BS",theEntity.EFFECTIVE_DATE_BS));
	
			if(!string.IsNullOrEmpty(theEntity.COLLAPSE_DATE_AD))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_COLLAPSE_DATE_AD",theEntity.COLLAPSE_DATE_AD));
	
			if(!string.IsNullOrEmpty(theEntity.COLLAPSE_DATE_BS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_COLLAPSE_DATE_BS",theEntity.COLLAPSE_DATE_BS));
	
			if(!string.IsNullOrEmpty(theEntity.DESCRIPTION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DESCRIPTION",theEntity.DESCRIPTION));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_DATE_AD))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_DATE_AD",theEntity.ORDER_DATE_AD));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_DATE_BS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_DATE_BS",theEntity.ORDER_DATE_BS));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_NO",theEntity.ORDER_NO));
	
			if(!string.IsNullOrEmpty(theEntity.AUTHORISED_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_AUTHORISED_BY",theEntity.AUTHORISED_BY));
	
			if(!string.IsNullOrEmpty(theEntity.AUTHORISED_POSITION_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_AUTHORISED_POSITION_CODE",theEntity.AUTHORISED_POSITION_CODE));
	
			if(!string.IsNullOrEmpty(theEntity.AUTHORISED_ORGANIZATION_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_AUTHORISED_ORG_CODE",theEntity.AUTHORISED_ORGANIZATION_CODE));
	
			if(!string.IsNullOrEmpty(theEntity.PREPARED_ON))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PREPARED_ON",theEntity.PREPARED_ON));
	
			if(!string.IsNullOrEmpty(theEntity.PREPARED_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PREPARED_BY",theEntity.PREPARED_BY));
	
			if(!string.IsNullOrEmpty(theEntity.DARBANDI_DEFINED_AS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DARBANDI_DEFINED_AS",theEntity.DARBANDI_DEFINED_AS));
	
			if(!string.IsNullOrEmpty(theEntity.ORG_TYPE_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORG_TYPE_CODE",theEntity.ORG_TYPE_CODE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            VW_ORGH theEntity = (VW_ORGH)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.ORG_STRUCTURE_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORG_STRUCTURE_CODE",theEntity.ORG_STRUCTURE_CODE));
	
			if(!string.IsNullOrEmpty(theEntity.ORG_STRUCTURE_NAME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORG_STRUCTURE_NAME",theEntity.ORG_STRUCTURE_NAME));
	
			if(!string.IsNullOrEmpty(theEntity.ORG_STRUCTURE_NAME_DEVNAGARI))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORG_STRUCTURE_NAME_DEV",theEntity.ORG_STRUCTURE_NAME_DEVNAGARI));
	
			if(!string.IsNullOrEmpty(theEntity.UPPER_ORG_STRUCTURE_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_UPPER_ORG_STRUCTURE_CODE",theEntity.UPPER_ORG_STRUCTURE_CODE));
	
			if(!string.IsNullOrEmpty(theEntity.HIERARCHY_NAME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_HIERARCHY_NAME",theEntity.HIERARCHY_NAME));
	
			if(!string.IsNullOrEmpty(theEntity.ADDRESS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ADDRESS",theEntity.ADDRESS));
	
			if(!string.IsNullOrEmpty(theEntity.LOCATION_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_LOCATION_CODE",theEntity.LOCATION_CODE));
	
			if(!string.IsNullOrEmpty(theEntity.TELEPHONE_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TELEPHONE_NO",theEntity.TELEPHONE_NO));
	
			if(!string.IsNullOrEmpty(theEntity.GRADE_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_GRADE_CODE",theEntity.GRADE_CODE));
	
			if(!string.IsNullOrEmpty(theEntity.ORG_UNIT_TYPE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORG_UNIT_TYPE",theEntity.ORG_UNIT_TYPE));
	
			if(!string.IsNullOrEmpty(theEntity.EFFECTIVE_DATE_AD))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_EFFECTIVE_DATE_AD",theEntity.EFFECTIVE_DATE_AD));
	
			if(!string.IsNullOrEmpty(theEntity.EFFECTIVE_DATE_BS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_EFFECTIVE_DATE_BS",theEntity.EFFECTIVE_DATE_BS));
	
			if(!string.IsNullOrEmpty(theEntity.COLLAPSE_DATE_AD))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_COLLAPSE_DATE_AD",theEntity.COLLAPSE_DATE_AD));
	
			if(!string.IsNullOrEmpty(theEntity.COLLAPSE_DATE_BS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_COLLAPSE_DATE_BS",theEntity.COLLAPSE_DATE_BS));
	
			if(!string.IsNullOrEmpty(theEntity.DESCRIPTION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DESCRIPTION",theEntity.DESCRIPTION));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_DATE_AD))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_DATE_AD",theEntity.ORDER_DATE_AD));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_DATE_BS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_DATE_BS",theEntity.ORDER_DATE_BS));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_NO",theEntity.ORDER_NO));
	
			if(!string.IsNullOrEmpty(theEntity.AUTHORISED_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_AUTHORISED_BY",theEntity.AUTHORISED_BY));
	
			if(!string.IsNullOrEmpty(theEntity.AUTHORISED_POSITION_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_AUTHORISED_POSITION_CODE",theEntity.AUTHORISED_POSITION_CODE));
	
			if(!string.IsNullOrEmpty(theEntity.AUTHORISED_ORGANIZATION_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_AUTHORISED_ORG_CODE",theEntity.AUTHORISED_ORGANIZATION_CODE));
	
			if(!string.IsNullOrEmpty(theEntity.PREPARED_ON))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PREPARED_ON",theEntity.PREPARED_ON));
	
			if(!string.IsNullOrEmpty(theEntity.PREPARED_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PREPARED_BY",theEntity.PREPARED_BY));
	
			if(!string.IsNullOrEmpty(theEntity.DARBANDI_DEFINED_AS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DARBANDI_DEFINED_AS",theEntity.DARBANDI_DEFINED_AS));
	
			if(!string.IsNullOrEmpty(theEntity.ORG_TYPE_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORG_TYPE_CODE",theEntity.ORG_TYPE_CODE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            VW_ORGH theEntity = (VW_ORGH)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.ORG_STRUCTURE_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORG_STRUCTURE_CODE",theEntity.ORG_STRUCTURE_CODE));
	
			if(!string.IsNullOrEmpty(theEntity.ORG_STRUCTURE_NAME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORG_STRUCTURE_NAME",theEntity.ORG_STRUCTURE_NAME));
	
			if(!string.IsNullOrEmpty(theEntity.ORG_STRUCTURE_NAME_DEVNAGARI))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORG_STRUCTURE_NAME_DEV",theEntity.ORG_STRUCTURE_NAME_DEVNAGARI));
	
			if(!string.IsNullOrEmpty(theEntity.UPPER_ORG_STRUCTURE_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_UPPER_ORG_STRUCTURE_CODE",theEntity.UPPER_ORG_STRUCTURE_CODE));
	
			if(!string.IsNullOrEmpty(theEntity.HIERARCHY_NAME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_HIERARCHY_NAME",theEntity.HIERARCHY_NAME));
	
			if(!string.IsNullOrEmpty(theEntity.ADDRESS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ADDRESS",theEntity.ADDRESS));
	
			if(!string.IsNullOrEmpty(theEntity.LOCATION_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_LOCATION_CODE",theEntity.LOCATION_CODE));
	
			if(!string.IsNullOrEmpty(theEntity.TELEPHONE_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TELEPHONE_NO",theEntity.TELEPHONE_NO));
	
			if(!string.IsNullOrEmpty(theEntity.GRADE_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_GRADE_CODE",theEntity.GRADE_CODE));
	
			if(!string.IsNullOrEmpty(theEntity.ORG_UNIT_TYPE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORG_UNIT_TYPE",theEntity.ORG_UNIT_TYPE));
	
			if(!string.IsNullOrEmpty(theEntity.EFFECTIVE_DATE_AD))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_EFFECTIVE_DATE_AD",theEntity.EFFECTIVE_DATE_AD));
	
			if(!string.IsNullOrEmpty(theEntity.EFFECTIVE_DATE_BS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_EFFECTIVE_DATE_BS",theEntity.EFFECTIVE_DATE_BS));
	
			if(!string.IsNullOrEmpty(theEntity.COLLAPSE_DATE_AD))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_COLLAPSE_DATE_AD",theEntity.COLLAPSE_DATE_AD));
	
			if(!string.IsNullOrEmpty(theEntity.COLLAPSE_DATE_BS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_COLLAPSE_DATE_BS",theEntity.COLLAPSE_DATE_BS));
	
			if(!string.IsNullOrEmpty(theEntity.DESCRIPTION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DESCRIPTION",theEntity.DESCRIPTION));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_DATE_AD))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_DATE_AD",theEntity.ORDER_DATE_AD));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_DATE_BS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_DATE_BS",theEntity.ORDER_DATE_BS));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_NO",theEntity.ORDER_NO));
	
			if(!string.IsNullOrEmpty(theEntity.AUTHORISED_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_AUTHORISED_BY",theEntity.AUTHORISED_BY));
	
			if(!string.IsNullOrEmpty(theEntity.AUTHORISED_POSITION_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_AUTHORISED_POSITION_CODE",theEntity.AUTHORISED_POSITION_CODE));
	
			if(!string.IsNullOrEmpty(theEntity.AUTHORISED_ORGANIZATION_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_AUTHORISED_ORG_CODE",theEntity.AUTHORISED_ORGANIZATION_CODE));
	
			if(!string.IsNullOrEmpty(theEntity.PREPARED_ON))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PREPARED_ON",theEntity.PREPARED_ON));
	
			if(!string.IsNullOrEmpty(theEntity.PREPARED_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PREPARED_BY",theEntity.PREPARED_BY));
	
			if(!string.IsNullOrEmpty(theEntity.DARBANDI_DEFINED_AS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DARBANDI_DEFINED_AS",theEntity.DARBANDI_DEFINED_AS));
	
			if(!string.IsNullOrEmpty(theEntity.ORG_TYPE_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORG_TYPE_CODE",theEntity.ORG_TYPE_CODE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            VW_ORGH theEntity = (VW_ORGH)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.ORG_STRUCTURE_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORG_STRUCTURE_CODE",theEntity.ORG_STRUCTURE_CODE));
	
			if(!string.IsNullOrEmpty(theEntity.ORG_STRUCTURE_NAME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORG_STRUCTURE_NAME",theEntity.ORG_STRUCTURE_NAME));
	
			if(!string.IsNullOrEmpty(theEntity.ORG_STRUCTURE_NAME_DEVNAGARI))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORG_STRUCTURE_NAME_DEV",theEntity.ORG_STRUCTURE_NAME_DEVNAGARI));
	
			if(!string.IsNullOrEmpty(theEntity.UPPER_ORG_STRUCTURE_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_UPPER_ORG_STRUCTURE_CODE",theEntity.UPPER_ORG_STRUCTURE_CODE));
	
			if(!string.IsNullOrEmpty(theEntity.HIERARCHY_NAME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_HIERARCHY_NAME",theEntity.HIERARCHY_NAME));
	
			if(!string.IsNullOrEmpty(theEntity.ADDRESS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ADDRESS",theEntity.ADDRESS));
	
			if(!string.IsNullOrEmpty(theEntity.LOCATION_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_LOCATION_CODE",theEntity.LOCATION_CODE));
	
			if(!string.IsNullOrEmpty(theEntity.TELEPHONE_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TELEPHONE_NO",theEntity.TELEPHONE_NO));
	
			if(!string.IsNullOrEmpty(theEntity.GRADE_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_GRADE_CODE",theEntity.GRADE_CODE));
	
			if(!string.IsNullOrEmpty(theEntity.ORG_UNIT_TYPE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORG_UNIT_TYPE",theEntity.ORG_UNIT_TYPE));
	
			if(!string.IsNullOrEmpty(theEntity.EFFECTIVE_DATE_AD))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_EFFECTIVE_DATE_AD",theEntity.EFFECTIVE_DATE_AD));
	
			if(!string.IsNullOrEmpty(theEntity.EFFECTIVE_DATE_BS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_EFFECTIVE_DATE_BS",theEntity.EFFECTIVE_DATE_BS));
	
			if(!string.IsNullOrEmpty(theEntity.COLLAPSE_DATE_AD))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_COLLAPSE_DATE_AD",theEntity.COLLAPSE_DATE_AD));
	
			if(!string.IsNullOrEmpty(theEntity.COLLAPSE_DATE_BS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_COLLAPSE_DATE_BS",theEntity.COLLAPSE_DATE_BS));
	
			if(!string.IsNullOrEmpty(theEntity.DESCRIPTION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DESCRIPTION",theEntity.DESCRIPTION));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_DATE_AD))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_DATE_AD",theEntity.ORDER_DATE_AD));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_DATE_BS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_DATE_BS",theEntity.ORDER_DATE_BS));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_NO",theEntity.ORDER_NO));
	
			if(!string.IsNullOrEmpty(theEntity.AUTHORISED_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_AUTHORISED_BY",theEntity.AUTHORISED_BY));
	
			if(!string.IsNullOrEmpty(theEntity.AUTHORISED_POSITION_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_AUTHORISED_POSITION_CODE",theEntity.AUTHORISED_POSITION_CODE));
	
			if(!string.IsNullOrEmpty(theEntity.AUTHORISED_ORGANIZATION_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_AUTHORISED_ORG_CODE",theEntity.AUTHORISED_ORGANIZATION_CODE));
	
			if(!string.IsNullOrEmpty(theEntity.PREPARED_ON))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PREPARED_ON",theEntity.PREPARED_ON));
	
			if(!string.IsNullOrEmpty(theEntity.PREPARED_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PREPARED_BY",theEntity.PREPARED_BY));
	
			if(!string.IsNullOrEmpty(theEntity.DARBANDI_DEFINED_AS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DARBANDI_DEFINED_AS",theEntity.DARBANDI_DEFINED_AS));
	
			if(!string.IsNullOrEmpty(theEntity.ORG_TYPE_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORG_TYPE_CODE",theEntity.ORG_TYPE_CODE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	