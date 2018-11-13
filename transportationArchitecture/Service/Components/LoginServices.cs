using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;
using Entity.Components;

using Service.Framework;
using DataAccess.Components;
using DataAccess.Framework;
namespace Service.Components
{
   public class LoginServices: AbstractService
    {

        #region Overridden Properties
        public override AbstractDAO dao
        {
            get
            {
                return new DataAccess.Components.LogDAO();
            }
        }
        #endregion    


        public EntityBase Validate(string username, string password, string fiscalYear)
        {
            UserProfileEntity userProfile = new UserProfileEntity();
            userProfile.UserName = username;
            userProfile.Password = password;
            LogDAO Logdao = new DataAccess.Components.LogDAO();
            userProfile = (UserProfileEntity) Logdao.GetValidUser(userProfile);
            if (userProfile == null)
            {
                userProfile = new UserProfileEntity();
                userProfile.LoginAccess = false;
                userProfile.Remarks = "No Such User Exists";

            }
            else
            {
                if (userProfile.Accessblocked == true)
                {
                    userProfile.LoginAccess = false;
                    userProfile.Remarks = "Your Login Has Been Disabled by The Administrator. Contact the Administrator.";
                }
                else
                {
                    userProfile.LoginAccess = true;
                    userProfile.Remarks = "You have successfuly Logned. Your Profile is being generated please wait.";
                }
            }
            return userProfile;
        }
    }
}
