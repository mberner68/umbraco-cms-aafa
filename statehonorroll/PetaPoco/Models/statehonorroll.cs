using System;
using Umbraco.Core.Persistence;
using Umbraco.Core.Persistence.DatabaseAnnotations;

namespace statehonorroll.PetaPoco.Models
{
  [TableName ("CMSStateInfo")]
  [PrimaryKey("idno",autoIncrement = true)]
  [ExplicitColumns]

  public class States {
      
        [Column ("idno")]
        [PrimaryKeyColumn(AutoIncrement =true)]
        public int id { get; set; }

        [Column ("statename")]
        [Length(30)]
        public string statename { get; set; }

        [Column ("Q1")]
        [Length (3)]
        public string Q1 { get; set; }

        [Column ("Q2")]
        [Length (3)]
        public string Q2 { get; set; }

        [Column ("Q3")]
        [Length (3)]
        public string Q3 { get; set; }

        [Column ("Q4")]
        [Length (3)]
        public string Q4 { get; set; }

        [Column ("Q5")]
        [Length (3)]
        public string Q5 { get; set; }

        [Column ("Q6")]
        [Length (3)]
        public string Q6 { get; set; }

        [Column ("Q7")]
        [Length (3)]
        public string Q7 { get; set; }

        [Column ("Q8")]
        [Length (3)]
        public string Q8 { get; set; }

        [Column ("Q9")]
        [Length (3)]
        public string Q9 { get; set; }

        [Column ("Q10")]
        [Length (3)]
        public string Q10 { get; set; }

        [Column ("Q11")]
        [Length (3)]
        public string Q11 { get; set; }

        [Column ("Q12")]
        [Length (3)]
        public string Q12 { get; set; }

        [Column ("QA")]
        [Length (3)]
        public string QA { get; set; }

        [Column ("QB")]
        [Length (3)]
        public string QB { get; set; }

        [Column ("QC")]
        [Length (3)]
        public string QC { get; set; }

        [Column ("QD")]
        [Length (3)]
        public string QD { get; set; }

        [Column ("QE")]
        [Length (3)]
        public string QE { get; set; }

        [Column ("QF")]
        [Length (3)]
        public string QF { get; set; }

        [Column ("Q13")]
        [Length (3)]
        public string Q13 { get; set; }

        [Column ("Q14")]
        [Length (3)]
        public string Q14 { get; set; }

        [Column ("QG")]
        [Length (3)]
        public string QG { get; set; }

        [Column ("QH")]
        [Length (3)]
        public string QH { get; set; }

        [Column ("Q15")]
        [Length (3)]
        public string Q15 { get; set; }

        [Column ("Q16")]
        [Length (3)]
        public string Q16 { get; set; }

        [Column ("Q17")]
        [Length (3)]
        public string Q17 { get; set; }

        [Column ("Q18")]
        [Length (3)]
        public string Q18 { get; set; }

        [Column ("Q19")]
        [Length (3)]
        public string Q19 { get; set; }

        [Column ("Q20")]
        [Length (3)]
        public string Q20 { get; set; }

        [Column ("Q21")]
        [Length (3)]
        public string Q21 { get; set; }

        [Column ("Q22")]
        [Length (3)]
        public string Q22 { get; set; }

        [Column ("Q23")]
        [Length (3)]
        public string Q23 { get; set; }

        [Column ("QI")]
        [Length (3)]
        public string QI { get; set; }

        [Column ("QJ")]
        [Length (3)]
        public string QJ { get; set; }

        [Column ("QK")]
        [Length (3)]
        public string QK { get; set; }

        [Column ("QL")]
        [Length (3)]
        public string QL { get; set; }

        [Column ("QM")]
        [Length (3)]
        public string QM { get; set; }

        [Column("policygap")]
        [SpecialDbType(SpecialDbTypes.NTEXT)]
        [NullSetting(NullSetting = NullSettings.Null)]
        public string policygap { get; set; }

        [Column("noteworthy")]
        [SpecialDbType(SpecialDbTypes.NTEXT)]
        [NullSetting(NullSetting = NullSettings.Null)]
        public string noteworthy { get; set; }

        [Column("sources")]
        [SpecialDbType(SpecialDbTypes.NTEXT)]
        [NullSetting(NullSetting = NullSettings.Null)]
        public string sources { get; set; }

        [Column("imageurl")]
        [SpecialDbType(SpecialDbTypes.NTEXT)]
        [NullSetting(NullSetting = NullSettings.Null)]
        public string imageurl { get; set; }
  }
  
  
  
  
}
