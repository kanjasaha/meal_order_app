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
    
    public partial class NotificationFrequency
    {
        public NotificationFrequency()
        {
            this.UserSettings = new HashSet<UserSetting>();
            this.UserSettings1 = new HashSet<UserSetting>();
        }
    
        public int NotificationFrequencyID { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<UserSetting> UserSettings { get; set; }
        public virtual ICollection<UserSetting> UserSettings1 { get; set; }
    }
}
