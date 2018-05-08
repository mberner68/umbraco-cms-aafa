using System;
using Umbraco.Core.Persistence;
using Umbraco.Core.Persistence.DatabaseAnnotations;

namespace recipes.PetaPoco.Models
{
    [TableName("CMIngredients")]
    [PrimaryKey("IngredientId", autoIncrement = true)]
    [ExplicitColumns]
    public class Ingredients
    {
        [Column("IngredientId")]
        [PrimaryKeyColumn(AutoIncrement = true)]
        public int IngredientId { get; set; }

        [Column("RecipeId")]
        [ForeignKey(typeof(Recipe), Name = "FK_Ingredient")]
        [IndexAttribute(IndexTypes.NonClustered, Name = "IX_RecipeId")]
        public int RecipeId { get; set; }

        [Column("Qunatity")]
        [Length(50)]
        public string Quantity { get; set; }

        [Column("Measurement")]
        [Length(40)]
        public string Measurement { get; set; }

        [Column("IngredientName")]
        [Length(500)]
        public string IngredientName { get; set; }

        [Column("OptionalInfo")]
        [Length(500)]
        [NullSetting(NullSetting =NullSettings.Null)]
        public string OptionalInfo { get; set; }

        [Column ("IngredientOrder")]
        public int IngredientOrder { get; set; }

        [Column("CreateDate")]
        public DateTime CreateDate { get; set; }

        [Column("ModifiedDate")]
        public DateTime ModifiedDate { get; set; }

        [Column ("TipId")]
        [NullSetting(NullSetting = NullSettings.Null)]
        public int TipId { get; set; }

        [Column("IngredientSequence")]
        [NullSetting(NullSetting = NullSettings.Null)]
        public int IngredientSequence { get; set; }
    }

}