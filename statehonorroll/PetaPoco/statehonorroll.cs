using statehonorroll.PetaPoco.Models;
using System.Collections.Generic;
using Umbraco.Core.Persistence;

namespace statehonorroll.PetaPoco.Repository
{
    public static class State
    {
        
        public static IList<Points> GetPoints(string statename)
        {
            UmbracoDatabase db = Umbraco.Core.ApplicationContext.Current.DatabaseContext.Database;
            return db.Fetch<Points>("SELECT * FROM CMSPoints WHERE statename = @0", statename);

        }
        public static IList<States> GetInfo(string statename)
        {
            UmbracoDatabase db = Umbraco.Core.ApplicationContext.Current.DatabaseContext.Database;
            return db.Fetch<States>("SELECT * FROM CMSStateInfo WHERE statename = @0", statename);

        }
        




    }





}