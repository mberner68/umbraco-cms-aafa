using System;
using Umbraco.Core.Persistence;
using Umbraco.Core.Persistence.DatabaseAnnotations;

namespace recipes.PetaPoco.Models
{
    [TableName("CMCategory")]
    [PrimaryKey("CategoryID", autoIncrement = true)]
    [ExplicitColumns]
    public class Category
    {
        [Column("CategoryID")]
        [PrimaryKeyColumn(AutoIncrement = true)]
        public int CategoryID { get; set; }

        [Column("CategoryName")]
        [Length(100)]
         public string CategoryName { get; set; }

       [Column("CreateDate")]
        public DateTime CreateDate { get; set; }

        [Column("ModifiedDate")]
        public DateTime ModifiedDate { get; set; }

    }
}