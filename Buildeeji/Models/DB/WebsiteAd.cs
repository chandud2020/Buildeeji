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
    
    public partial class WebsiteAd
    {
        public int WebsiteAdId { get; set; }
        public string Details { get; set; }
        public string ImageUrl { get; set; }
        public string TagLine { get; set; }
        public string Url { get; set; }
        public Nullable<System.DateTime> Start { get; set; }
        public Nullable<System.DateTime> Expire { get; set; }
        public int CreatedBY { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public int UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
    }
}
