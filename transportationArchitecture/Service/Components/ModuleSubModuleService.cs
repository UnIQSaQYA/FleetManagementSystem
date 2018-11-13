using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;
using Entity.Components;
using System.Data;

using Service.Framework;
using DataAccess.Components;
using DataAccess.Framework;
namespace Service.Components
{
   public class ModuleSubModuleService: AbstractService
    {

        #region Overridden Properties
        public override AbstractDAO dao
        {
            get
            {
                return new DataAccess.Components.ModuleSubModulesDAO();
            }
        }
        #endregion    


        public EntityList GetMainModules(UserProfileEntity userProfile)
        {
            ModulePermissionDAO Logdao = new DataAccess.Components.ModulePermissionDAO();
            return Logdao.GetAll(userProfile);
        }

        public DataSet GetMainModuleDS(UserProfileEntity userProfile)
        {
            ModulePermissionDAO Logdao = new DataAccess.Components.ModulePermissionDAO();
            return Logdao.GetDataSet(userProfile);
        }

        public EntityList GetValideModules(UserProfileEntity userProfile)
        {
            ModuleSubModulesDAO Logdao = new DataAccess.Components.ModuleSubModulesDAO();
            return Logdao.GetModuleSubModule(userProfile);
        }

        public EntityList GetValideModules(UserProfileEntity userProfile,string CurrentMod_ID)
        {
            ModuleSubModulesDAO Logdao = new DataAccess.Components.ModuleSubModulesDAO();
            return Logdao.GetModuleSubModule(userProfile, CurrentMod_ID);
        }
        public EntityList GetLinkNodes(ModuleSubmoduleEntity ModuleSubModule)
        {
            PageLinkNodeDAO Logdao = new DataAccess.Components.PageLinkNodeDAO();
            return Logdao.GetLinkNodes(ModuleSubModule);
        }
       public EntityList GetLinkNodes(ModuleSubmoduleEntity ModuleSubModule,string CurrentMod_ID)
        {
            PageLinkNodeDAO Logdao = new DataAccess.Components.PageLinkNodeDAO();
            return Logdao.GetLinkNodes(ModuleSubModule, CurrentMod_ID);
        }
    }
}
