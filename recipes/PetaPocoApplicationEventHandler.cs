using recipes.PetaPoco.Models;
using Umbraco.Core;
using Umbraco.Core.Persistence;

namespace recipes.PetaPoco
{
    public class PetaPocoApplicationEventHandler : ApplicationEventHandler
    {
        protected override void ApplicationStarted(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            var ctx = applicationContext.DatabaseContext;
            var db = new DatabaseSchemaHelper(ctx.Database, applicationContext.ProfilingLogger.Logger, ctx.SqlSyntax);

            if (!db.TableExist("CMRecipes"))
            {
                db.CreateTable<Recipe>(false);
            }
            if (!db.TableExist("CMAllergen"))
            {
                db.CreateTable<Allergren>(false);
            }
            if (!db.TableExist("CMImages"))
            {
                db.CreateTable<Images>(false);
            }
            if (!db.TableExist("CMCategory"))
            {
                db.CreateTable<Category>(false);
            }
            if (!db.TableExist("CMRoles"))
            {
                db.CreateTable<Roles>(false);
            }
            if (!db.TableExist("CMStatus"))
            {
                db.CreateTable <RecStatus>(false);
            }
            if (!db.TableExist("CMRecipeDelete"))
            {
                db.CreateTable<RecipeDelete>(false);
            }
            if (!db.TableExist("CMIngredients"))
            {
                db.CreateTable<Ingredients>(false);
            }
            if (!db.TableExist("CMTips"))
            {
                db.CreateTable<Tips>(false);
            }
            if (!db.TableExist("CMIngredientTips"))
            {
                db.CreateTable<IngredientTips>(false);
            }
            if (!db.TableExist("CMUser"))
            {
                db.CreateTable<User>(false);
            }
            if (!db.TableExist("CMRating"))
            {
                db.CreateTable<Rating>(false);
            }
            if (!db.TableExist("CMRecipeAllergen"))
            {
                db.CreateTable<RecipeAllergren>(false);
            }
            if (!db.TableExist("CMRecipeImage"))
            {
                db.CreateTable<RecipeImage>(false);
            }
            if (!db.TableExist("CMUserFavorites"))
            {
                db.CreateTable<UserFavorite>(false);
            }























        }
    }
}