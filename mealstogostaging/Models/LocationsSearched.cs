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
    
    public partial class LocationsSearched
    {
        public int SearchID { get; set; }
        public int UserID { get; set; }
        public string Location { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public System.DateTime DateCreated { get; set; }
        public string Keywords { get; set; }
        public Nullable<System.DateTime> DateRangeStart { get; set; }
        public Nullable<System.DateTime> DateRangeEnd { get; set; }
        public Nullable<int> Distance { get; set; }
        public string DistanceUnit { get; set; }
    }
}
