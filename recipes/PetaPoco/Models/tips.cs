using System;
using Umbraco.Core.Persistence;
using Umbraco.Core.Persistence.DatabaseAnnotations;

namespace recipes.PetaPoco.Models
{
    [TableName("CMTip")]
    [PrimaryKey("TipId", autoIncrement = true)]
    [ExplicitColumns]
    public class Tips
    {
        [Column("TipId")]
        [PrimaryKeyColumn(AutoIncrement = true)]
        public int TipId { get; set; }

        [Column ("TipDescription")]
        [Length(4000)]
        public string TipDescription { get; set; }

        [Column("TipType")]
        [Length(100)]
        public string TipType { get; set; }

        [Column("CreateDate")]
        public DateTime CreateDate { get; set; }

        [Column("ModifiedDate")]
        public DateTime ModifiedDate { get; set; }
    }

}