using System;
using Umbraco.Core.Persistence;
using Umbraco.Core.Persistence.DatabaseAnnotations;

namespace recipes.PetaPoco.Models
{
    [TableName("CMAllergen")]
    [PrimaryKey("AllergenID", autoIncrement =true)]
    [ExplicitColumns]
    public class Allergren
    {
        [Column("AllergenID")]
        [PrimaryKeyColumn(AutoIncrement = true)]
        public int AllergenID { get; set; }

        [Column ("AllergenName")]
        [Length(100)]
        [NullSetting(NullSetting =NullSettings.Null)]
        public string AllergenName { get; set; }

        [Column("ThumbnailImage")]
        [Length(1000)]
        [NullSetting(NullSetting = NullSettings.Null)]
        public string ThumbnailImage { get; set; }

        [Column("CreateDate")]
        public DateTime CreateDate { get; set; }

        [Column("ModifiedDate")]
        public DateTime ModifiedDate { get; set; }

    }
}