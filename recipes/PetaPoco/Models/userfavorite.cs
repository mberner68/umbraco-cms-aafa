using System;
using Umbraco.Core.Persistence;
using Umbraco.Core.Persistence.DatabaseAnnotations;

namespace recipes.PetaPoco.Models
{
    [TableName("CMUserFavorites")]
    [PrimaryKey("UserFavoriteId", autoIncrement = true)]
    [ExplicitColumns]
    public class UserFavorite
    {
        [Column("UserFavoriteId")]
        [PrimaryKeyColumn(AutoIncrement = true)]
        public int UserFavoriteId { get; set; }

        [Column("UserId")]
        [ForeignKey(typeof(User), Name = "FK_UserFavorite")]
        [IndexAttribute(IndexTypes.NonClustered, Name = "IX_UserId")]
        public int UserId { get; set; }

        [Column("RecipeId")] 
        public int Recipeid { get; set; }

        [Column("CreateDate")]
        public DateTime CreateDate { get; set; }

    }
}
