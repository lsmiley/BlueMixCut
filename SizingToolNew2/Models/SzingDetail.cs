using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SizingToolNew2.Models
{
    public class SizingDetail
    {

        
       // [DatabaseGeneratedAttribute(DatabaseGeneratedOption.None)]
       // [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        
        [Key, ForeignKey("Sizing")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]  // Not db-generated
        public int SizingId { get; set; }
        public string SizingData { get; set; }
        public string NoteDesc { get; set; }
        public string Note { get; set; }

        [Display(Name = "Memo / Note")]
        [DataType(DataType.MultilineText)]
        public string MemoNote1 { get; set; }

        [Display(Name = "Memo / Note")]
        [DataType(DataType.MultilineText)]
        public string MemoNote2 { get; set; }

        [Display(Name = "Memo / Note")]
        [DataType(DataType.MultilineText)]
        public string MemoNote3 { get; set; }

        [Display(Name = "Memo / Note")]
        [DataType(DataType.MultilineText)]
        public string MemoNote4 { get; set; }

        [Display(Name = "Memo / Note")]
        [DataType(DataType.MultilineText)]
        public string MemoNote5 { get; set; }

        [Display(Name = "Memo / Note")]
        [DataType(DataType.MultilineText)]
        public string MemoNote6 { get; set; }

        [Display(Name = "Memo / Note")]
        [DataType(DataType.MultilineText)]
        public string MemoNote7 { get; set; }


        //Navigation property Returns the Sizing object
        //      public Sizing Sizing { get; set; }

        
        public virtual Sizing Sizing { get; set; }
        //
       
    //
    //Navigation property Returns the Employee object
    //    public virtual Sizing Sizing { get; set; }

 




    }
    }