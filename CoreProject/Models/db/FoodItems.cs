using System;
using System.Collections.Generic;

namespace CoreProject.Models.db
{
    public partial class FoodItems
    {
        public int Id { get; set; }
        public string Descr { get; set; }
        public int? CatId { get; set; }
        public double? Price { get; set; }
        public double? Discount { get; set; }
        public string ImagePath { get; set; }
        public int? MealTypeId { get; set; }
        public int? RestaurantId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? LastDateModified { get; set; }
        public int? LastUpdatedBy { get; set; }
        public int? QualityId { get; set; }
        public int? MenuId { get; set; }
    }
}