//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CourseManager
{
    using System;
    using System.Collections.Generic;
    
    public partial class Person
    {
        public Person()
        {
            this.StudentGrade = new HashSet<StudentGrade>();
            this.Course = new HashSet<Course>();
        }
    
        public int PersonID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public Nullable<System.DateTime> HireDate { get; set; }
        public Nullable<System.DateTime> EnrollmentDate { get; set; }
    
        public virtual OfficeAssignment OfficeAssignment { get; set; }
        public virtual ICollection<StudentGrade> StudentGrade { get; set; }
        public virtual ICollection<Course> Course { get; set; }
    }
}
