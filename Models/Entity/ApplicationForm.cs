namespace LCUP.Models.Entity
{
    public class ApplicationForm
    {

        public int Student_Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Nickname { get; set; }
        public DateOnly BirthDate { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string Citizenship { get; set; }
        public string Religion { get; set; }
        public string Birth_Place { get; set; }
        public int? SiblingsCount { get; set; }
        public int? Birth_Order { get; set; }
        public string Email { get; set; }
        public string Present_Address { get; set; }
        public string? Landline_Number { get; set; }
        public string Mobile_Number { get; set; }
        public string Permanent_Address { get; set; }
        public string? GenAvgRank { get; set; }
        public DateOnly Graduation_Date { get; set; }
        public string? Talent_Skills { get; set; }
        public string? Hobbies_Interests { get; set; }
        public string Language_Spoken { get; set; }


    }

    public class ApplicationForm2
    {
        public int Student_Id { get; set; }
        public string FullName { get; set; }
        public string Citizenship { get; set; }
        public string Religion { get; set; }
        public string Birth_Place { get; set; }
        public string Age { get; set; }
        public DateOnly BirthDate { get; set; }
        public string Highest_Education_Attainment { get; set; }
        public string School_Graduated_Form { get; set; }
        public string Present_Address { get; set; }
        public int Mobile_Number { get; set; }
        public string Email { get; set; }
        public string Occupational { get; set; }
        public string Employer { get; set; }
        public string Bussiness_Address { get; set; }
        public int Annual_Income { get; set; }
    }
}
