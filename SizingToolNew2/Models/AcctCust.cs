using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SizingToolNew2.Models
{
    public class AcctCust

{
    private DateTime _created;

    public AcctCust()

    { }

    public int AcctCustId { get; set; }
    public string AcctName { get; set; }
    public string BusinessSec { get; set; }
    public string Regulatory { get; set; }

        // ******** Start Section - Date and Time Calculations - Created Da        private DateTime _created = DateTime.MinValue;

        [Display(Name = "Created On")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Created
        {
            get
            {
                return (_created == DateTime.MinValue) ? DateTime.Now : _created;
            }
            set { _created = value; }
        }
        // ********Date and Time Calculations - Created



        //  public DateTime ValidToDate { get; set; }
        public string Address1 { get; set; }
    public string Address2 { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public string Contact1Name { get; set; }
    public string Contact1Phone { get; set; }
    public string Contact1Email { get; set; }
    public string Contact2Name { get; set; }
    public string Contact2Phone { get; set; }
    public string Contact2Email { get; set; }
    public string WebURL { get; set; }
    public string CreatedBy { get; set; }
    // public string CreteDate { get; set; }
    public string ModifyDate { get; set; }


    public virtual ICollection<Sizing> Sizings { get; set; }
 //   public virtual ICollection<Sizing> Sizings { get; set; }



}
}
