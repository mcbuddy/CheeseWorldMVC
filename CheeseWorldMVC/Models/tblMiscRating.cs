//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CheeseWorldMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblMiscRating
    {
        public int MiscRatingID { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<int> MiscProductID { get; set; }
        public Nullable<decimal> RatingScore { get; set; }
        public string CustomerComment { get; set; }
    
        public virtual tblCustomer tblCustomer { get; set; }
        public virtual tblMiscProduct tblMiscProduct { get; set; }
    }
}
