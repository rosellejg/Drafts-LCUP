using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCUP.Models
{
    public class ApplicationFormDB
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Student_Id { get; set; }

        [Unicode]
        [MaxLength(255)]
        public string LastName { get; set; }


        [Unicode]
        [MaxLength(255)]
        public string FirstName { get; set; }


        [Unicode]
        [MaxLength(255)]
        public string MiddleName { get; set; }

        [Unicode]
        [MaxLength(255)]
        public string Nickname { get; set; }

        public DateOnly BirthDate { get; set; }


        [Range(0, 100)]
        public int Age { get; set; }

        [MaxLength(255)]
        public string Sex { get; set; }

        [MaxLength(255)]
        public string Citizenship { get; set; }

        [MaxLength(255)]
        public string Religion { get; set; }

        [Unicode]
        [MaxLength(255)]
        public string Birth_Place { get; set; }


        [Range(0, 100)]
        public int? SiblingsCount { get; set; }

        [Range(0, 100)]
        public int? Birth_Order { get; set; }

        [MaxLength(255)]
        public string Email { get; set; }

        [MaxLength(255)]
        public string Present_Address { get; set; }

        [MaxLength(255)]
        public string? Landline_Number { get; set; }

        [MaxLength(255)]
        public string Mobile_Number { get; set; }

        [MaxLength(255)]
        public string Permanent_Address { get; set; }

        [MaxLength(255)]
        public string? GenAvgRank { get; set; }

        public DateOnly Graduation_Date { get; set; }

        [MaxLength(255)]
        public string? Talent_Skills { get; set; }

        [MaxLength(255)]
        public string? Hobbies_Interests { get; set; }

        [MaxLength(255)]
        public string Language_Spoken { get; set; }
    }
    public class ApplicationFormDB2
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Student_Id { get; set; }

        [MaxLength(255)]
        public string FullName { get; set; }

        [MaxLength(255)]
        public string Citizenship { get; set; }

        [MaxLength(255)]
        public string Religion { get; set; }

        [MaxLength(255)]
        public string Birth_Place { get; set; }

        [MaxLength(255)]
        public string Age { get; set; }

        public DateOnly BirthDate { get; set; }

        [MaxLength(255)]
        public string Highest_Education_Attainment { get; set; }

        [MaxLength(255)]
        public string School_Graduated_Form { get; set; }

        [MaxLength(255)]
        public string Present_Address { get; set; }

        [MaxLength(255)]
        public string Mobile_Number { get; set; }

        [MaxLength(255)]
        public string Email { get; set; }

        [MaxLength(255)]
        public string Occupational { get; set; }

        [MaxLength(255)]
        public string Employer { get; set; }

        [MaxLength(255)]
        public string Bussiness_Address { get; set; }

        [Range(0, 100)]
        public int Annual_Income { get; set; }

    }

    public class ApplicationFormDB3
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Entity_Id { get; set; }

        [MaxLength(255)]
        public string FullName { get; set; }

        [MaxLength(255)]
        public string Relationship { get; set; }

        [MaxLength(255)]
        public int Contact_Number { get; set; }

        [MaxLength(255)]
        public string Email { get; set; }

        [MaxLength(255)]
        public string Present_Address { get; set; }
    }
}