//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IPLManagementSystemWEBAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Player
    {
        public int Id { get; set; }
        public Nullable<int> TeamId { get; set; }
        public string Name { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<int> SpecialityId { get; set; }
        public Nullable<int> PhotoId { get; set; }
    
        public virtual PlayerPhoto PlayerPhoto { get; set; }
        public virtual Speciality Speciality { get; set; }
        public virtual Team Team { get; set; }
    }
}