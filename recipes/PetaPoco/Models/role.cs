using System;
using Umbraco.Core.Persistence;
using Umbraco.Core.Persistence.DatabaseAnnotations;

namespace recipes.PetaPoco.Models
{
    [TableName("CMRoles")]
    [PrimaryKey("RoleId", autoIncrement = true)]
    [ExplicitColumns]
    public class Roles
    {
        [Column("RoleId")]
        [PrimaryKeyColumn(AutoIncrement = true)]
        public int RoleId { get; set; }

        [Column("RoleName")]
        [Length(100)]
        public string RoleName { get; set; }

        [Column("CreateDate")]
        public DateTime CreateDate { get; set; }

        [Column("ModifiedDate")]
        public DateTime ModifiedDate { get; set; }

    }
}