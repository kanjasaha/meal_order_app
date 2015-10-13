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
    
    public partial class MealItem
    {
        public MealItem()
        {
            this.MealItems_AllergenicFoods = new HashSet<MealItems_AllergenicFoods>();
            this.MealItems_Photos = new HashSet<MealItems_Photos>();
            this.MealAds = new HashSet<MealAd>();
            this.MealAds1 = new HashSet<MealAd>();
        }
    
        public int MealItemId { get; set; }
        public int UserId { get; set; }
        public string MealItemName { get; set; }
        public string Ingredients { get; set; }
        public int ServingUnit { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public int Status { get; set; }
        public int CusineTypeID { get; set; }
        public int MealTypeID { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public Nullable<int> DietTypeID { get; set; }
        public Nullable<int> ApprovalStatus { get; set; }
        public Nullable<System.DateTime> ApprovalStatusDate { get; set; }
    
        public virtual LKUPCuisineType LKUPCuisineType { get; set; }
        public virtual LKUPDietType LKUPDietType { get; set; }
        public virtual LKUPMealType LKUPMealType { get; set; }
        public virtual LKUPServingUnit LKUPServingUnit { get; set; }
        public virtual ICollection<MealItems_AllergenicFoods> MealItems_AllergenicFoods { get; set; }
        public virtual ICollection<MealItems_Photos> MealItems_Photos { get; set; }
        public virtual ICollection<MealAd> MealAds { get; set; }
        public virtual ICollection<MealAd> MealAds1 { get; set; }
    }
}
