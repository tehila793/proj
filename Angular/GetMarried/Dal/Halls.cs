//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dal
{
    using System;
    using System.Collections.Generic;
    
    public partial class Halls
    {
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string fax { get; set; }
        public Nullable<int> invited { get; set; }
        public string kashrut { get; set; }
        public Nullable<int> price { get; set; }
        public int idtype { get; set; }
        public int idCategory { get; set; }
        public int idAddress { get; set; }
        public int idOpinion { get; set; }
    
        public virtual Address Address { get; set; }
        public virtual Categories Categories { get; set; }
        public virtual Opinion Opinion { get; set; }
        public virtual HallType HallType { get; set; }
    }
}
