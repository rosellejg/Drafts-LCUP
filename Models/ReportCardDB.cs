using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCUP.Models
{
    public class ReportCardDB
    {
        [Range(0, 100)]
        public int Academic_Year_Id { get; set; }

        [Range(0, 100)]
        public int Grading_Period_Id { get; set; }

        [Range(0, 100)]
        public int LRN { get; set; }

        [Key]
        public int Student_Id { get; set; }
    
        [MaxLength(50)]
        public string FullName { get; set; }

        [Range(0, 100)]
        public int Subject_Id { get; set; }

        [Range(0, 100)]

        public int Academic_Grade { get; set; }

        [Range(0, 100)]
        public int Subject_Conduct_Grade { get; set; }

        [Range(0, 100)]
        public int Average_Grade { get; set; }

        [Range(0, 100)]
        public int Homeroom_Grade_Id { get; set; }

        [Range(0, 100)]
        public int Club_Grade_Id { get; set; }

        [Range(0, 100)]
        public int Mandarin_Grade_Id { get; set; }

        [Range(0, 100)]
        public int CXLC_Id { get; set; }

        [Range(0, 100)]
        public int Conduct_Average { get; set; }
    }
}
