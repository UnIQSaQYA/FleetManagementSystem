using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Configuration.Provider;
using System.Collections.Specialized;

using Entity.Components;
using Entity.Framework;
using Service.Components;
using Service.Framework;
using NCCSEncryption;

using System.Web;

namespace NCCS
{
    public class SiteMapDataProvider : StaticSiteMapProvider
    {
        #region Members
        private readonly object _siteMapLock = new object();
        private SiteMapNode _siteMapRoot;
        #endregion
        #region Methods
        public override SiteMapNode BuildSiteMap()
        {            // Use a lock to provide thread safety            
            lock (_siteMapLock)
            {
                if (_siteMapRoot != null)
                {
                    return _siteMapRoot;
                }
                base.Clear();
                CreateSiteMapRoot();
                CreateSiteMapNodes();
                return _siteMapRoot;
            }
        }

        protected override SiteMapNode GetRootNodeCore()
        {
            return BuildSiteMap();
        }

        private void CreateSiteMapRoot()
        {
            _siteMapRoot = new SiteMapNode(this, "Root", "~/Default.aspx", "Root");
            AddNode(_siteMapRoot);
        }

        private void CreateSiteMapNodes()
        {
            SiteMapNode node = null;
            for (int i = 1; i <= 3; i++)
            {
                node = new SiteMapNode(this, string.Format("Child{0}", i), string.Format("~/WebForm{0}.aspx", i), string.Format("Child{0}", i));
                AddNode(node, _siteMapRoot);
            }
        }
        #endregion
    }
}

//namespace NCCS
//{
//    public class SiteMapDataProvider : StaticSiteMapProvider
//    {
//        Encryption MyEncr = new Encryption();
//        private readonly object _siteMapLock = new object();
//        private SiteMapNode _siteMapRoot;

//        public override SiteMapNode BuildSiteMap()
//        {
//            //if (_siteMapRoot != null && HttpContext.Current.Session["AlreadySet"] != null) return _siteMapRoot;
//            // Use a lock to provide thread safety            
//            lock (_siteMapLock)
//            {
//                //if (_siteMapRoot != null)
//                //{
//                //    return _siteMapRoot;
//                //}
//                //next line is better to put on the first statement after "if", for concurrent reason
//                //HttpContext.Current.Session["AlreadySet"] = true;
//                base.Clear();
//                CreateSiteMapRoot();
//                CreateSiteMapNodes();
//                return _siteMapRoot;
//            }
//        }

//        protected override SiteMapNode GetRootNodeCore()
//        {
//            return BuildSiteMap();
//        }

//        private void CreateSiteMapRoot()
//        {
//            _siteMapRoot = new SiteMapNode(this, "Root", "~/Default.aspx", "Root");
//            AddNode(_siteMapRoot);
//        }

//        private void CreateSiteMapNodes()
//        {
//            UserProfileEntity userProfileEnt = new UserProfileEntity();
//            userProfileEnt = (UserProfileEntity)HttpContext.Current.Session["UserProfile"];
//            ModuleSubModuleService srv = new ModuleSubModuleService();
//            EntityList entList = new EntityList();
//            entList = srv.GetValideModules(userProfileEnt);
//            SiteMapNode node = null;
//            int i = 0;
//            foreach (ModuleSubmoduleEntity ent in entList)
//            {
//                node = new SiteMapNode(this, string.Format(ent.Name, i), string.Format("", i), string.Format(ent.Name, i));
//                EntityList entListNodes = new EntityList();
//                entListNodes = srv.GetLinkNodes(ent);
//                SiteMapNode nodeLink = null;
//                int j = 0;
//                foreach (PageLinkNodesEntity entNode in entListNodes)
//                {
//                    string Pageurl = entNode.LinkUrl + "?";
//                    string QueryParamters = "";
//                    QueryParamters = "Access=267b&";
//                    QueryParamters = QueryParamters + "Role=" + ent.Role;
//                    QueryParamters = MyEncr.Encrypt(QueryParamters, "!#$a54?3");
//                    Pageurl = Pageurl + QueryParamters;
//                    nodeLink = new SiteMapNode(this, string.Format(entNode.Pagename, j), string.Format(Pageurl, j), string.Format(entNode.Pagename, j));
//                    AddNode(nodeLink, node);
//                    nodeLink = null;
//                    j = j++;
//                }
//                AddNode(node, _siteMapRoot);
//                i = i++;
//            }
//        }
//    }
//}