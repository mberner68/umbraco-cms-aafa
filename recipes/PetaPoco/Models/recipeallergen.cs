using System;
using Umbraco.Core.Persistence;
using Umbraco.Core.Persistence.DatabaseAnnotations;

namespace recipes.PetaPoco.Models
{
    [TableName("CMRecipeAllergen")]
    [PrimaryKey("RecipeAllergenID", autoIncrement = true)]
    [ExplicitColumns]
    public class RecipeAllergren
    {
        [Column("RecipeAllergenID")]
        [PrimaryKeyColumn(AutoIncrement = true)]
        public int RecipeAllergenID { get; set; }

        [Column("AllergenID")]
        [ForeignKey(typeof(Allergren), Name = "FK_RecipeAllergen01")]
        [IndexAttribute(IndexTypes.NonClustered, Name = "IX_AllergenID")]
        public int AllergenID { get; set; }

        [Column("RecipeId")]
        [ForeignKey(typeof(Recipe), Name = "FK_RecipeAllergen02")]
        [IndexAttribute(IndexTypes.NonClustered, Name = "IX_RecipeId")]
        public int RecipeId { get; set; }

        [Column("CreateDate")]
        public DateTime CreateDate { get; set; }


    }
}