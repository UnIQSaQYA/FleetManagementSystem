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
    public class EXTERNAL_WORKSHOPDAO : DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public EXTERNAL_WORKSHOPDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTEXTERNAL_WORKSHOP";


            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYEXTERNAL_WORKSHOP";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYEXTERNAL_WORKSHOP";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYEXTERNAL_WORKSHOP";
            }
        }
        #endregion

        #region Overridden Methods

        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
            EXTERNAL_WORKSHOP theEntity = new EXTERNAL_WORKSHOP();

            theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;

            theEntity.WORKSHOP_ID = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;

            theEntity.WORKSHOP_NAME = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;

            theEntity.ADDRESS = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;

            theEntity.DISTRICT = !dr.IsDBNull(4) ? dr.GetValue(4).ToString() : string.Empty;

            theEntity.OFFICE_PHONE = !dr.IsDBNull(5) ? dr.GetValue(5).ToString() : string.Empty;

            theEntity.OFFICE_EMAIL = !dr.IsDBNull(6) ? dr.GetValue(6).ToString() : string.Empty;

            theEntity.OFFICE_WEBSITE = !dr.IsDBNull(7) ? dr.GetValue(7).ToString() : string.Empty;

            theEntity.OFFICE_FAX = !dr.IsDBNull(8) ? dr.GetValue(8).ToString() : string.Empty;

            theEntity.VAT_PAN = !dr.IsDBNull(9) ? dr.GetValue(9).ToString() : string.Empty;

            theEntity.VAT_PAN_NUMBER = !dr.IsDBNull(10) ? dr.GetValue(10).ToString() : string.Empty;

            theEntity.CONTACT_PERSON = !dr.IsDBNull(11) ? dr.GetValue(11).ToString() : string.Empty;

            theEntity.CONTACT_NO = !dr.IsDBNull(12) ? dr.GetValue(12).ToString() : string.Empty;

            theEntity.REMARKS = !dr.IsDBNull(13) ? dr.GetValue(13).ToString() : string.Empty;

            theEntity.STATUS = !dr.IsDBNull(14) ? dr.GetValue(14).ToString() : string.Empty;


            return theEntity;
        }

        protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            EXTERNAL_WORKSHOP theEntity = (EXTERNAL_WORKSHOP)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();

            if (!string.IsNullOrEmpty(theEntity.PK_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID", theEntity.PK_ID));

            if (!string.IsNullOrEmpty(theEntity.WORKSHOP_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_WORKSHOP_ID", theEntity.WORKSHOP_ID));

            if (!string.IsNullOrEmpty(theEntity.WORKSHOP_NAME))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_WORKSHOP_NAME", theEntity.WORKSHOP_NAME));

            if (!string.IsNullOrEmpty(theEntity.ADDRESS))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ADDRESS", theEntity.ADDRESS));

            if (!string.IsNullOrEmpty(theEntity.DISTRICT))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DISTRICT", theEntity.DISTRICT));

            if (!string.IsNullOrEmpty(theEntity.OFFICE_PHONE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_PHONE", theEntity.OFFICE_PHONE));

            if (!string.IsNullOrEmpty(theEntity.OFFICE_EMAIL))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_EMAIL", theEntity.OFFICE_EMAIL));

            if (!string.IsNullOrEmpty(theEntity.OFFICE_WEBSITE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_WEBSITE", theEntity.OFFICE_WEBSITE));

            if (!string.IsNullOrEmpty(theEntity.OFFICE_FAX))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_FAX", theEntity.OFFICE_FAX));

            if (!string.IsNullOrEmpty(theEntity.VAT_PAN))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VAT_PAN", theEntity.VAT_PAN));

            if (!string.IsNullOrEmpty(theEntity.VAT_PAN_NUMBER))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VAT_PAN_NUMBER", theEntity.VAT_PAN_NUMBER));

            if (!string.IsNullOrEmpty(theEntity.CONTACT_PERSON))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CONTACT_PERSON", theEntity.CONTACT_PERSON));

            if (!string.IsNullOrEmpty(theEntity.CONTACT_NO))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CONTACT_NO", theEntity.CONTACT_NO));

            if (!string.IsNullOrEmpty(theEntity.REMARKS))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REMARKS", theEntity.REMARKS));

            if (!string.IsNullOrEmpty(theEntity.STATUS))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_STATUS", theEntity.STATUS));


            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));

            return cmdParams.ToArray();
        }

        protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            EXTERNAL_WORKSHOP theEntity = (EXTERNAL_WORKSHOP)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode", "i"));

            if (!string.IsNullOrEmpty(theEntity.PK_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID", theEntity.PK_ID));

            if (!string.IsNullOrEmpty(theEntity.WORKSHOP_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_WORKSHOP_ID", theEntity.WORKSHOP_ID));

            if (!string.IsNullOrEmpty(theEntity.WORKSHOP_NAME))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_WORKSHOP_NAME", theEntity.WORKSHOP_NAME));

            if (!string.IsNullOrEmpty(theEntity.ADDRESS))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ADDRESS", theEntity.ADDRESS));

            if (!string.IsNullOrEmpty(theEntity.DISTRICT))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DISTRICT", theEntity.DISTRICT));

            if (!string.IsNullOrEmpty(theEntity.OFFICE_PHONE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_PHONE", theEntity.OFFICE_PHONE));

            if (!string.IsNullOrEmpty(theEntity.OFFICE_EMAIL))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_EMAIL", theEntity.OFFICE_EMAIL));

            if (!string.IsNullOrEmpty(theEntity.OFFICE_WEBSITE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_WEBSITE", theEntity.OFFICE_WEBSITE));

            if (!string.IsNullOrEmpty(theEntity.OFFICE_FAX))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_FAX", theEntity.OFFICE_FAX));

            if (!string.IsNullOrEmpty(theEntity.VAT_PAN))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VAT_PAN", theEntity.VAT_PAN));

            if (!string.IsNullOrEmpty(theEntity.VAT_PAN_NUMBER))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VAT_PAN_NUMBER", theEntity.VAT_PAN_NUMBER));

            if (!string.IsNullOrEmpty(theEntity.CONTACT_PERSON))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CONTACT_PERSON", theEntity.CONTACT_PERSON));

            if (!string.IsNullOrEmpty(theEntity.CONTACT_NO))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CONTACT_NO", theEntity.CONTACT_NO));

            if (!string.IsNullOrEmpty(theEntity.REMARKS))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REMARKS", theEntity.REMARKS));

            if (!string.IsNullOrEmpty(theEntity.STATUS))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_STATUS", theEntity.STATUS));


            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));

            return cmdParams.ToArray();
        }

        protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            EXTERNAL_WORKSHOP theEntity = (EXTERNAL_WORKSHOP)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode", "u"));

            if (!string.IsNullOrEmpty(theEntity.PK_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID", theEntity.PK_ID));

            if (!string.IsNullOrEmpty(theEntity.WORKSHOP_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_WORKSHOP_ID", theEntity.WORKSHOP_ID));

            if (!string.IsNullOrEmpty(theEntity.WORKSHOP_NAME))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_WORKSHOP_NAME", theEntity.WORKSHOP_NAME));

            if (!string.IsNullOrEmpty(theEntity.ADDRESS))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ADDRESS", theEntity.ADDRESS));

            if (!string.IsNullOrEmpty(theEntity.DISTRICT))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DISTRICT", theEntity.DISTRICT));

            if (!string.IsNullOrEmpty(theEntity.OFFICE_PHONE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_PHONE", theEntity.OFFICE_PHONE));

            if (!string.IsNullOrEmpty(theEntity.OFFICE_EMAIL))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_EMAIL", theEntity.OFFICE_EMAIL));

            if (!string.IsNullOrEmpty(theEntity.OFFICE_WEBSITE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_WEBSITE", theEntity.OFFICE_WEBSITE));

            if (!string.IsNullOrEmpty(theEntity.OFFICE_FAX))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_FAX", theEntity.OFFICE_FAX));

            if (!string.IsNullOrEmpty(theEntity.VAT_PAN))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VAT_PAN", theEntity.VAT_PAN));

            if (!string.IsNullOrEmpty(theEntity.VAT_PAN_NUMBER))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VAT_PAN_NUMBER", theEntity.VAT_PAN_NUMBER));

            if (!string.IsNullOrEmpty(theEntity.CONTACT_PERSON))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CONTACT_PERSON", theEntity.CONTACT_PERSON));

            if (!string.IsNullOrEmpty(theEntity.CONTACT_NO))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CONTACT_NO", theEntity.CONTACT_NO));

            if (!string.IsNullOrEmpty(theEntity.REMARKS))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REMARKS", theEntity.REMARKS));

            if (!string.IsNullOrEmpty(theEntity.STATUS))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_STATUS", theEntity.STATUS));


            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));

            return cmdParams.ToArray();
        }

        protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            EXTERNAL_WORKSHOP theEntity = (EXTERNAL_WORKSHOP)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode", "d"));

            if (!string.IsNullOrEmpty(theEntity.PK_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID", theEntity.PK_ID));

            if (!string.IsNullOrEmpty(theEntity.WORKSHOP_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_WORKSHOP_ID", theEntity.WORKSHOP_ID));

            if (!string.IsNullOrEmpty(theEntity.WORKSHOP_NAME))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_WORKSHOP_NAME", theEntity.WORKSHOP_NAME));

            if (!string.IsNullOrEmpty(theEntity.ADDRESS))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ADDRESS", theEntity.ADDRESS));

            if (!string.IsNullOrEmpty(theEntity.DISTRICT))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DISTRICT", theEntity.DISTRICT));

            if (!string.IsNullOrEmpty(theEntity.OFFICE_PHONE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_PHONE", theEntity.OFFICE_PHONE));

            if (!string.IsNullOrEmpty(theEntity.OFFICE_EMAIL))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_EMAIL", theEntity.OFFICE_EMAIL));

            if (!string.IsNullOrEmpty(theEntity.OFFICE_WEBSITE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_WEBSITE", theEntity.OFFICE_WEBSITE));

            if (!string.IsNullOrEmpty(theEntity.OFFICE_FAX))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_FAX", theEntity.OFFICE_FAX));

            if (!string.IsNullOrEmpty(theEntity.VAT_PAN))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VAT_PAN", theEntity.VAT_PAN));

            if (!string.IsNullOrEmpty(theEntity.VAT_PAN_NUMBER))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VAT_PAN_NUMBER", theEntity.VAT_PAN_NUMBER));

            if (!string.IsNullOrEmpty(theEntity.CONTACT_PERSON))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CONTACT_PERSON", theEntity.CONTACT_PERSON));

            if (!string.IsNullOrEmpty(theEntity.CONTACT_NO))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CONTACT_NO", theEntity.CONTACT_NO));

            if (!string.IsNullOrEmpty(theEntity.REMARKS))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REMARKS", theEntity.REMARKS));

            if (!string.IsNullOrEmpty(theEntity.STATUS))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_STATUS", theEntity.STATUS));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));

            return cmdParams.ToArray();
        }

        #endregion
    }
}

