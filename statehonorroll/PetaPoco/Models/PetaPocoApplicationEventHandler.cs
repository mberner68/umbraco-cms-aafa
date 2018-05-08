using statehonorroll.PetaPoco.Models;
using Umbraco.Core;
using Umbraco.Core.Persistence;

namespace statehonorroll.PetaPoco
{
    public class PetaPocoApplicationEventHandler : ApplicationEventHandler
    {
        protected override void ApplicationStarted(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            var ctx = applicationContext.DatabaseContext;
            var db = new DatabaseSchemaHelper(ctx.Database, applicationContext.ProfilingLogger.Logger, ctx.SqlSyntax);

            if (!db.TableExist("CMSPoints"))
            {
                db.CreateTable<Points>(false);
            }
            if (!db.TableExist("CMSStateInfo"))
            {
                db.CreateTable<States>(false);
            }
            
        }
    }
}