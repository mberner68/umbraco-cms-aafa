using System;
using Umbraco.Core.Persistence;
using Umbraco.Core.Persistence.DatabaseAnnotations;

namespace recipes.PetaPoco.Models
{
    [TableName("CMStatus")]
    [PrimaryKey("StatusId", autoIncrement = true)]
    [ExplicitColumns]
    public class RecStatus
    {
        [Column("StatusId")]
        [PrimaryKeyColumn(AutoIncrement = true)]
        public int StatusId { get; set; }

        [Column("Status")]
        [Length(100)]
        public string Status { get; set; }

        [Column("CreateDate")]
        public DateTime CreateDate { get; set; }

        [Column("ModifiedDate")]
        public DateTime ModifiedDate { get; set; }

    }
}