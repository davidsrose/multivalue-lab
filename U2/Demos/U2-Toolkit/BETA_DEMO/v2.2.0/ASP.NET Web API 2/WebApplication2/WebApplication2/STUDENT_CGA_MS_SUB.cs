//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2
{
    using System;
    using System.Collections.Generic;
    
    public partial class STUDENT_CGA_MS_SUB
    {
        public string ID { get; set; }
        public int CGA_MV_KEY { get; set; }
        public int CGA_MS_KEY { get; set; }
        public string COURSE_NBR { get; set; }
        public string COURSE_HOURS { get; set; }
        public string COURSE_NAME { get; set; }
        public string TEACHER { get; set; }
        public string COURSE_GRD { get; set; }
    
        public virtual STUDENT_CGA_MV_SUB STUDENT_CGA_MV_SUB { get; set; }
    }
}