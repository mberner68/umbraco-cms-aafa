using System;
using Umbraco.Core.Persistence;
using Umbraco.Core.Persistence.DatabaseAnnotations;

namespace recipes.PetaPoco.Models
{
    [TableName("CMRating")]
    [PrimaryKey("RatingId", autoIncrement = true)]
    [ExplicitColumns]
    public class Rating
    {
        [Column("RatingId")]
        [PrimaryKeyColumn(AutoIncrement = true)]
        public int RatingId { get; set; }

        [Column("RecipeId")]
        [ForeignKey(typeof(Recipe), Name = "FK_Rating")]
        [IndexAttribute(IndexTypes.NonClustered, Name = "IX_RecipeId")]
        public int RecipeId { get; set; }

        [Column("RatingValue")]
        public int RatingValue { get; set; }

        [Column("RatingDate")]
        [NullSetting(NullSetting = NullSettings.Null)]
        public DateTime RatingDate { get; set; }

        [Column("CreateDate")]
        public DateTime CreateDate { get; set; }

        [Column("ModifiedDate")]
        public DateTime ModifiedDate { get; set; }

    }

}