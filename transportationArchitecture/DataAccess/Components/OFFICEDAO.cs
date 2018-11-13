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
    public class OFFICEDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public OFFICEDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTOFFICE";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYOFFICE";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYOFFICE";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYOFFICE";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			OFFICE theEntity = new OFFICE();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.OFFICECODE = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.OFFICENAME = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.WARDNO = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			theEntity.STREET = !dr.IsDBNull(4) ? dr.GetValue(4).ToString() : string.Empty;
	
			theEntity.VDCMUNICIPALITY = !dr.IsDBNull(5) ? dr.GetValue(5).ToString() : string.Empty;
	
			theEntity.OFFICETYPEID = !dr.IsDBNull(6) ? dr.GetValue(6).ToString() : string.Empty;
	
			theEntity.WORKSASDEPOT = !dr.IsDBNull(7) ? dr.GetValue(7).ToString() : string.Empty;
	
			theEntity.REGIONID = !dr.IsDBNull(8) ? dr.GetValue(8).ToString() : string.Empty;
	
			theEntity.CONTACT_PERSON = !dr.IsDBNull(9) ? dr.GetValue(9).ToString() : string.Empty;
	
			theEntity.PHONE_NO = !dr.IsDBNull(10) ? dr.GetValue(10).ToString() : string.Empty;
	
			theEntity.MOBILE_NO = !dr.IsDBNull(11) ? dr.GetValue(11).ToString() : string.Empty;
	
			theEntity.EMAIL = !dr.IsDBNull(12) ? dr.GetValue(12).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            OFFICE theEntity = (OFFICE)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.OFFICECODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICECODE",theEntity.OFFICECODE));
	
			if(!string.IsNullOrEmpty(theEntity.OFFICENAME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICENAME",theEntity.OFFICENAME));
	
			if(!string.IsNullOrEmpty(theEntity.WARDNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_WARDNO",theEntity.WARDNO));
	
			if(!string.IsNullOrEmpty(theEntity.STREET))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_STREET",theEntity.STREET));
	
			if(!string.IsNullOrEmpty(theEntity.VDCMUNICIPALITY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VDCMUNICIPALITY",theEntity.VDCMUNICIPALITY));
	
			if(!string.IsNullOrEmpty(theEntity.OFFICETYPEID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICETYPEID",theEntity.OFFICETYPEID));
	
			if(!string.IsNullOrEmpty(theEntity.WORKSASDEPOT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_WORKSASDEPOT",theEntity.WORKSASDEPOT));
	
			if(!string.IsNullOrEmpty(theEntity.REGIONID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REGIONID",theEntity.REGIONID));
	
			if(!string.IsNullOrEmpty(theEntity.CONTACT_PERSON))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CONTACT_PERSON",theEntity.CONTACT_PERSON));
	
			if(!string.IsNullOrEmpty(theEntity.PHONE_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PHONE_NO",theEntity.PHONE_NO));
	
			if(!string.IsNullOrEmpty(theEntity.MOBILE_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MOBILE_NO",theEntity.MOBILE_NO));
	
			if(!string.IsNullOrEmpty(theEntity.EMAIL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_EMAIL",theEntity.EMAIL));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            OFFICE theEntity = (OFFICE)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.OFFICECODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICECODE",theEntity.OFFICECODE));
	
			if(!string.IsNullOrEmpty(theEntity.OFFICENAME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICENAME",theEntity.OFFICENAME));
	
			if(!string.IsNullOrEmpty(theEntity.WARDNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_WARDNO",theEntity.WARDNO));
	
			if(!string.IsNullOrEmpty(theEntity.STREET))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_STREET",theEntity.STREET));
	
			if(!string.IsNullOrEmpty(theEntity.VDCMUNICIPALITY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VDCMUNICIPALITY",theEntity.VDCMUNICIPALITY));
	
			if(!string.IsNullOrEmpty(theEntity.OFFICETYPEID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICETYPEID",theEntity.OFFICETYPEID));
	
			if(!string.IsNullOrEmpty(theEntity.WORKSASDEPOT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_WORKSASDEPOT",theEntity.WORKSASDEPOT));
	
			if(!string.IsNullOrEmpty(theEntity.REGIONID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REGIONID",theEntity.REGIONID));
	
			if(!string.IsNullOrEmpty(theEntity.CONTACT_PERSON))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CONTACT_PERSON",theEntity.CONTACT_PERSON));
	
			if(!string.IsNullOrEmpty(theEntity.PHONE_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PHONE_NO",theEntity.PHONE_NO));
	
			if(!string.IsNullOrEmpty(theEntity.MOBILE_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MOBILE_NO",theEntity.MOBILE_NO));
	
			if(!string.IsNullOrEmpty(theEntity.EMAIL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_EMAIL",theEntity.EMAIL));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            OFFICE theEntity = (OFFICE)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.OFFICECODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICECODE",theEntity.OFFICECODE));
	
			if(!string.IsNullOrEmpty(theEntity.OFFICENAME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICENAME",theEntity.OFFICENAME));
	
			if(!string.IsNullOrEmpty(theEntity.WARDNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_WARDNO",theEntity.WARDNO));
	
			if(!string.IsNullOrEmpty(theEntity.STREET))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_STREET",theEntity.STREET));
	
			if(!string.IsNullOrEmpty(theEntity.VDCMUNICIPALITY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VDCMUNICIPALITY",theEntity.VDCMUNICIPALITY));
	
			if(!string.IsNullOrEmpty(theEntity.OFFICETYPEID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICETYPEID",theEntity.OFFICETYPEID));
	
			if(!string.IsNullOrEmpty(theEntity.WORKSASDEPOT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_WORKSASDEPOT",theEntity.WORKSASDEPOT));
	
			if(!string.IsNullOrEmpty(theEntity.REGIONID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REGIONID",theEntity.REGIONID));
	
			if(!string.IsNullOrEmpty(theEntity.CONTACT_PERSON))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CONTACT_PERSON",theEntity.CONTACT_PERSON));
	
			if(!string.IsNullOrEmpty(theEntity.PHONE_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PHONE_NO",theEntity.PHONE_NO));
	
			if(!string.IsNullOrEmpty(theEntity.MOBILE_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MOBILE_NO",theEntity.MOBILE_NO));
	
			if(!string.IsNullOrEmpty(theEntity.EMAIL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_EMAIL",theEntity.EMAIL));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            OFFICE theEntity = (OFFICE)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.OFFICECODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICECODE",theEntity.OFFICECODE));
	
			if(!string.IsNullOrEmpty(theEntity.OFFICENAME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICENAME",theEntity.OFFICENAME));
	
			if(!string.IsNullOrEmpty(theEntity.WARDNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_WARDNO",theEntity.WARDNO));
	
			if(!string.IsNullOrEmpty(theEntity.STREET))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_STREET",theEntity.STREET));
	
			if(!string.IsNullOrEmpty(theEntity.VDCMUNICIPALITY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VDCMUNICIPALITY",theEntity.VDCMUNICIPALITY));
	
			if(!string.IsNullOrEmpty(theEntity.OFFICETYPEID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICETYPEID",theEntity.OFFICETYPEID));
	
			if(!string.IsNullOrEmpty(theEntity.WORKSASDEPOT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_WORKSASDEPOT",theEntity.WORKSASDEPOT));
	
			if(!string.IsNullOrEmpty(theEntity.REGIONID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REGIONID",theEntity.REGIONID));
	
			if(!string.IsNullOrEmpty(theEntity.CONTACT_PERSON))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CONTACT_PERSON",theEntity.CONTACT_PERSON));
	
			if(!string.IsNullOrEmpty(theEntity.PHONE_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PHONE_NO",theEntity.PHONE_NO));
	
			if(!string.IsNullOrEmpty(theEntity.MOBILE_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MOBILE_NO",theEntity.MOBILE_NO));
	
			if(!string.IsNullOrEmpty(theEntity.EMAIL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_EMAIL",theEntity.EMAIL));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	