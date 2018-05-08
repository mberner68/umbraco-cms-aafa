 using System;
using esg.PetaPoco.Models;
using System.Collections.Generic;
using Umbraco.Core.Persistence;


namespace esg.PetaPoco.Repository
{
    public static class SupportGroup
    {
        public static IList<SupportGroups> GetAll()
        {
            UmbracoDatabase db = Umbraco.Core.ApplicationContext.Current.DatabaseContext.Database;
            return db.Fetch<SupportGroups>("SELECT * FROM CMSupportGroups");
        }
        public static SupportGroups GetByName ( string name)
        {
            UmbracoDatabase db = Umbraco.Core.ApplicationContext.Current.DatabaseContext.Database;
            List<SupportGroups> States = db.Fetch<SupportGroups>("SELECT * FROM CMSupportGroups WHERE statename = @0, name");
            if (States.Count > 0)
                return States[0];
            else
                return null;
        }
        public static IList<SupportGroups> GetCount()
        {
            UmbracoDatabase db = Umbraco.Core.ApplicationContext.Current.DatabaseContext.Database;
            return db.Fetch<SupportGroups> ("SELECT DISTINCT statename, COUNT(groupname)FROM CMSupportGroups GROUP BY statename");

        }
    }



}
