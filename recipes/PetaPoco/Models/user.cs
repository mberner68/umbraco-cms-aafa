using System;
using Umbraco.Core.Persistence;
using Umbraco.Core.Persistence.DatabaseAnnotations;

namespace recipes.PetaPoco.Models
{
    [TableName("CMUser")]
    [PrimaryKey("UserId", autoIncrement = true)]
    [ExplicitColumns]
    public class User
    {
        [Column("UserId")]
        [PrimaryKeyColumn(AutoIncrement = true)]
        public int UserId { get; set; }

        [Column("RoleId")]
        [ForeignKey(typeof(Roles), Name = "FK_User")]
        [IndexAttribute(IndexTypes.NonClustered, Name = "IX_RoleId")]
        public int RoleId { get; set; }

        [Column("UserName")]
        [Length(50)]
        public string UserName { get; set; }

        [Column("EmailAddress")]
        [Length(250)]
        [NullSetting(NullSetting = NullSettings.Null)]
        public string EmailAddress { get; set; }

        [Column("CreateDate")]
        public DateTime CreateDate { get; set; }

        [Column("ModifiedDate")]
        public DateTime ModifiedDate { get; set; }

    }

}