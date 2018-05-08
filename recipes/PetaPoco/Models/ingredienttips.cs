using System;
using Umbraco.Core.Persistence;
using Umbraco.Core.Persistence.DatabaseAnnotations;

namespace recipes.PetaPoco.Models
{
    [TableName("CMIngredientTips")]
    [PrimaryKey("IngredientTipsid", autoIncrement = true)]
    [ExplicitColumns]
    public class IngredientTips
    {
        [Column("IngredientTipsid")]
        [PrimaryKeyColumn(AutoIncrement = true)]
        public int IngredientTipsid { get; set; }

        [Column("TipId")]
        [ForeignKey(typeof(Tips), Name = "FK_IngredientTips")]
        [IndexAttribute(IndexTypes.NonClustered, Name = "IX_TipId")]
        public int TipId { get; set; }

        [Column("IngredientId")]
        [ForeignKey(typeof(Ingredients), Name = "FK_IngredientTips_01")]
        [IndexAttribute(IndexTypes.NonClustered, Name = "IX_IngredientId")]
        public int IngredientId { get; set; }

        [Column("CreateDate")]
        public DateTime CreateDate { get; set; }

    }
}
