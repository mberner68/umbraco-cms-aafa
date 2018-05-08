using System;
using Umbraco.Core.Persistence;
using Umbraco.Core.Persistence.DatabaseAnnotations;

namespace recipes.PetaPoco.Models
{
    [TableName("CMRecipeDelete")]
    public class RecipeDelete
    {
        [Column("RecipeId")]
        public int id { get; set; }

        [Column("RecipeName")]
        [Length(250)]
        public string RecipeName { get; set; }

        [Column("Descriptions")]
        [SpecialDbType(SpecialDbTypes.NTEXT)]
        public string Descriptions { get; set; }

        [Column("Directions")]
        [SpecialDbType(SpecialDbTypes.NTEXT)]
        public string Directions { get; set; }

        [Column("ServingSize")]
        [Length(100)]
        [NullSetting(NullSetting = NullSettings.Null)]
        public string ServingSize { get; set; }

        [Column("DateSubmitted")]
        DateTime DateSubmitted { get; set; }

        [Column("DateApproved")]
        [NullSetting(NullSetting = NullSettings.Null)]
        DateTime DateApproved { get; set; }

        [Column("AdminNote")]
        [SpecialDbType(SpecialDbTypes.NTEXT)]
        [NullSetting(NullSetting = NullSettings.Null)]
        public string AdminNote { get; set; }

        [Column("SubsitutionNote")]
        [SpecialDbType(SpecialDbTypes.NTEXT)]
        [NullSetting(NullSetting = NullSettings.Null)]
        public string SubsitutionNote { get; set; }

        [Column("UsedId")]
        [NullSetting(NullSetting = NullSettings.Null)]
        public int UserId { get; set; }

        [Column("SubscriberName")]
        [Length(200)]
        [NullSetting(NullSetting = NullSettings.Null)]
        public string SubscriberName { get; set; }

        [Column("SubmitterComment")]
        [SpecialDbType(SpecialDbTypes.NTEXT)]
        [NullSetting(NullSetting = NullSettings.Null)]
        public string SubmitterComment { get; set; }

        [Column("CategoryID")]
        public int CategoryID { get; set; }

        [Column("StatusId")]
        public int StatusId { get; set; }

        [Column("CreatedDate")]
        DateTime CreatedDate { get; set; }

        [Column("ModifiedDate")]
        DateTime ModifiedDate { get; set; }

    }






}