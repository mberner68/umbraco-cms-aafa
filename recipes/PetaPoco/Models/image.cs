using System;
using Umbraco.Core.Persistence;
using Umbraco.Core.Persistence.DatabaseAnnotations;

namespace recipes.PetaPoco.Models
{
    [TableName("CMImages")]
    [PrimaryKey("ImageID", autoIncrement = true)]
    [ExplicitColumns]
    public class Images
    {
        [Column("ImageID")]
        [PrimaryKeyColumn(AutoIncrement = true)]
        public int ImageID { get; set; }

        [Column("ImageName")]
        [Length(100)]
        [NullSetting(NullSetting = NullSettings.Null)]
        public string ImageName { get; set; }

        [Column("DisplayImageFileName")]
        [Length(1000)]
        [NullSetting(NullSetting = NullSettings.Null)]
        public string DisplayImageFileName { get; set; }

        [Column("ThumbnailImageFileName")]
        [Length(1000)]
        [NullSetting(NullSetting = NullSettings.Null)]
        public string ThumbnailImageFileName { get; set; }

        [Column("ImageURL")]
        [Length(1000)]
        [NullSetting(NullSetting = NullSettings.Null)]
        public string ImageURL { get; set; }

        [Column("CreateDate")]
        public DateTime CreateDate { get; set; }

        [Column("ModifiedDate")]
        public DateTime ModifiedDate { get; set; }

        [Column("Approval")]
        [NullSetting(NullSetting = NullSettings.Null)]
        public int Approval { get; set; }

    }
}