using System;
using Umbraco.Core.Persistence;
using Umbraco.Core.Persistence.DatabaseAnnotations;

namespace esg.PetaPoco.Models
{
    [TableName("CMSupportGroups")]
    [PrimaryKey("id",autoIncrement = true)]
    [ExplicitColumns]
    public class SupportGroups
    {
        [Column ("id")]
        [PrimaryKeyColumn(AutoIncrement =true)]
        public int id { get; set; }

        [Column ("typeg")]
        [Length(20)]
        public string typeg { get; set; }

        [Column ("statename")]
        [Length(20)]
        public string statename { get; set; }

        [Column ("supportgroup")]
        [Length (3)]
        public string supportgroup { get; set; }

        [Column("groupname")]
        [Length(150)]
        [NullSetting(NullSetting =NullSettings.Null)]
        public string groupname { get; set; }

        [Column("areaserved")]
        [Length(200)]
        [NullSetting(NullSetting = NullSettings.Null)]
        public string areaserved { get; set; }

        [Column("audience")]
        [Length(200)]
        [NullSetting(NullSetting = NullSettings.Null)]
        public string audience { get; set; }

        [Column("focus")]
        [Length(200)]
        [NullSetting(NullSetting = NullSettings.Null)]
        public string focus { get; set; }

        [Column("location")]
        [SpecialDbType(SpecialDbTypes.NTEXT)]
        [NullSetting(NullSetting = NullSettings.Null)]
        public string location { get; set; }

        [Column("meetings")]
        [SpecialDbType(SpecialDbTypes.NTEXT)]
        [NullSetting(NullSetting = NullSettings.Null)]
        public string meetings { get; set; }

        [Column("coordinator")]
        [Length(90)]
        [NullSetting(NullSetting = NullSettings.Null)]
        public string coordinator { get; set; }

        [Column("medical_advisor")]
        [Length(90)]
        [NullSetting(NullSetting = NullSettings.Null)]
        public string medical_advisor { get; set; }

        [Column("phone")]
        [Length(30)]
        [NullSetting(NullSetting = NullSettings.Null)]
        public string phone { get; set; }

        [Column("fax")]
        [Length(30)]
        [NullSetting(NullSetting = NullSettings.Null)]
        public string fax{ get; set; }

        [Column("email")]
        [Length(250)]
        [NullSetting(NullSetting = NullSettings.Null)]
        public string email { get; set; }

        [Column("website")]
        [SpecialDbType(SpecialDbTypes.NTEXT)]
        [NullSetting(NullSetting = NullSettings.Null)]
        public string website { get; set; }
    }







}