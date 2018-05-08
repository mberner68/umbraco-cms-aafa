using System;
using Umbraco.Core.Persistence;
using Umbraco.Core.Persistence.DatabaseAnnotations;

namespace recipes.PetaPoco.Models
{
    [TableName("CMRecipeImage")]
    [PrimaryKey("RecipeImageId", autoIncrement = true)]
    [ExplicitColumns]
    public class RecipeImage
    {
        [Column("RecipeImageId")]
        [PrimaryKeyColumn(AutoIncrement = true)]
        public int RecipeImageId { get; set; }

        [Column("ImageId")]
        public int ImageId { get; set; }

        [Column("RecipeId")]
        [ForeignKey(typeof(Recipe), Name = "FK_Recipemages")]
        [IndexAttribute(IndexTypes.NonClustered, Name = "IX_RecipeId")]
        public int RecipeId { get; set; }

        [Column("CreateDate")]
        public DateTime CreateDate { get; set; }


    }
}