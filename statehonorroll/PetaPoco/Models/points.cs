using System;
using Umbraco.Core.Persistence;
using Umbraco.Core.Persistence.DatabaseAnnotations;

namespace statehonorroll.PetaPoco.Models
{
  [TableName ("CMSPoints")]
  [PrimaryKey("idno",autoIncrement = true)]
  [ExplicitColumns]

  public class Points {
      
        [Column ("idno")]
        [PrimaryKeyColumn(AutoIncrement =true)]
        public int idno { get; set; }

        [Column ("statename")]
        [Length(30)]
        public string statename { get; set; }

        [Column("medical_cp")]
        
        public int medical_cp {get; set;}

        [Column("medical_cpc")]
        
        public string medical_cpc {get; set;}

        [Column("medical_ci")]
        
        public int medical_ci {get; set;}

        [Column("medical_cic")]
        
        public string medical_cic {get; set;}

        [Column("awareness_cp")]      
        
        public int awareness_cp {get; set;}

         [Column("awareness_cpc")]      
        
        public string awareness_cpc {get; set;}

        [Column("awareness_ci")]

        public int awareness_ci {get; set;}

        [Column("awareness_cic")]

        public string awareness_cic {get; set;}

        [Column("school_cp")]      
        
        public int school_cp {get; set;}

        [Column("school_cpc")]      
        
        public string school_cpc {get; set;}

        [Column("school_ci")]

         public int school_ci {get; set;}
       
        [Column("school_cic")]
        
        public string school_cic {get; set;}

        [Column("total_cp")]      
        
        public int total_cp {get; set;}

        [Column("total_cpc")]      
        
        public string total_cpc {get; set;}
         
         [Column("total_ci")]

         public int total_ci {get; set;}
       
        [Column("total_cic")]
        
        public string total_cic {get; set;}
  }
  
  
  
  
}
