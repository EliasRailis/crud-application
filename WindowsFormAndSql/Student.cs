using System;

namespace WindowsFormAndSql
{
    /// <summary>
    /// The following class will be used for the creation of the Student object
    /// by creating the auto-implement properties for each field
    /// </summary>

    class Student
    {
        public int StudentID { get; set; }      // auto-implement property for StudentID
        public string Firstname { get; set; }   // auto-implement property for Firstname
        public string Lastname { get; set; }    // auto-implement property for Lasrname
        public string MI { get; set; }          // auto-implement property for Middle Initials
        public string Gender { get; set; }      // auto-implement property for Gender
        public string Address { get; set; }     // auto-implement property for Address
        public DateTime Birthday { get; set; }  // auto-implement property for Birthday
    }
}
