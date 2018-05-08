using esg.PetaPoco.Models;
using Umbraco.Core;
using Umbraco.Core.Persistence;

namespace esg.PetaPoco
{
    public class PetaPocoApplicationEventHandler : ApplicationEventHandler
    {
        protected override void ApplicationStarted(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            var ctx = applicationContext.DatabaseContext;
            var db = new DatabaseSchemaHelper(ctx.Database, applicationContext.ProfilingLogger.Logger, ctx.SqlSyntax);

            if (!db.TableExist("CMSupportGroups"))
            {
                db.CreateTable<SupportGroups>(false);
            }

            
        }
    }
}