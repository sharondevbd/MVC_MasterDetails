//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_MasterDetails_CRUD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Web;

    public partial class Applicant
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Applicant()
        {
            this.Applicant_Exprience = new List<Applicant_Exprience>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public System.DateTime Birthday { get; set; }
        public int TotalExprience { get; set; }
        public string PicPath { get; set; }
        [NotMapped]
        public HttpPostedFileBase Picture { get; set; }
        public bool IsAvilable { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<Applicant_Exprience> Applicant_Exprience { get; set; }
    }
}