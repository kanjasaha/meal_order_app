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
    
    public partial class AvailabilityType
    {
        public AvailabilityType()
        {
            this.MealAds = new HashSet<MealAd>();
        }
    
        public int AvaiilabilityTypeID { get; set; }
        public string AvailabilityType1 { get; set; }
        public string Descriptions { get; set; }
    
        public virtual ICollection<MealAd> MealAds { get; set; }
    }
}
