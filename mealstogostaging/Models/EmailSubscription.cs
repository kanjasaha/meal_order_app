//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MealsToGo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmailSubscription
    {
        public int EmailSubscriptionID { get; set; }
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public int ActivityTypeID { get; set; }
    }
}