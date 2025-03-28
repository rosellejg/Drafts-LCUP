namespace LCUP.Models
{
    public class ReportCardDTO
    {

        public int Academic_Year_Id { get; set; }
        public int Grading_Period_Id { get; set; }
        public int LRN { get; set; }
        public int Student_Id { get; set; }
        public string FullName { get; set; }

        public int Subject_Id { get; set; }

        public int Academic_Grade { get; set; }

        public int Subject_Conduct_Grade { get; set; }

        public int Average_Grade { get; set; }

        public int Homeroom_Grade_Id { get; set; }

        public int Club_Grade_Id { get; set; }
         public int Mandarin_Grade_Id { get; set; }
        public int CXLC_Id { get; set; }

        public int Conduct_Average { get; set; }


    }
}
