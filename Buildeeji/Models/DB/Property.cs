//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Buildeeji.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Property
    {
        public int PropertyId { get; set; }
        public string ListingTypeDescription { get; set; }
        public string CategoryDescription { get; set; }
        public string IsResale { get; set; }
        public Nullable<decimal> PropertyAge { get; set; }
        public Nullable<decimal> PropertyPrice { get; set; }
        public string PropertyProjectName { get; set; }
        public string PropertyProjectLocality { get; set; }
        public string PropertyAddress { get; set; }
        public string PropertyCity { get; set; }
        public Nullable<int> PropertyAddressPin { get; set; }
        public string PropertyMapLongitude { get; set; }
        public string PropertyMapLatitude { get; set; }
        public string PropertyComments { get; set; }
        public Nullable<decimal> PropertyBuiltUpArea { get; set; }
        public string PropertyBuiltUpAreaUnitType { get; set; }
        public Nullable<decimal> PropertyCarpetArea { get; set; }
        public string PropertyCarpetAreaUnitType { get; set; }
        public Nullable<decimal> PropertyPlotArea { get; set; }
        public string PropertyPlotAreaUnitType { get; set; }
        public Nullable<int> PropertyListedBy { get; set; }
        public Nullable<System.DateTime> PropertyListedOn { get; set; }
        public Nullable<int> PropertyPriyority { get; set; }
        public Nullable<int> LastUpdatedBy { get; set; }
        public Nullable<System.DateTime> LastUpdatedOn { get; set; }
    }
}
