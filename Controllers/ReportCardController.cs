using LCUP.Data;
using LCUP.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LCUP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportCardController : ControllerBase
    {
        public readonly ApplicationDbContext applicationDbContext;
        public ReportCardController(ApplicationDbContext appDbContext)
        {
            this.applicationDbContext = appDbContext;
        }

        [HttpPost("StudentReportCard")]
        public IActionResult StudentReportCard (ReportCardDTO reportCard)
        {
            var studentgrade = new ReportCardDB()
            {
                Academic_Year_Id = reportCard.Academic_Year_Id,
                Grading_Period_Id = reportCard.Grading_Period_Id,
                LRN = reportCard.LRN,
                Student_Id = reportCard.Student_Id,
                FullName = reportCard.FullName,
                Subject_Id = reportCard.Subject_Id,
                Academic_Grade = reportCard.Academic_Grade,
                Subject_Conduct_Grade = reportCard.Subject_Conduct_Grade,
                Average_Grade = reportCard.Average_Grade,
                Homeroom_Grade_Id = reportCard.Homeroom_Grade_Id,
                Club_Grade_Id = reportCard.Club_Grade_Id,
                Mandarin_Grade_Id = reportCard.Mandarin_Grade_Id,
                CXLC_Id = reportCard.CXLC_Id,
                Conduct_Average = reportCard.Conduct_Average

            };

            applicationDbContext.Report_Card.Add(studentgrade);
            applicationDbContext.SaveChanges();

           
            return Ok(studentgrade);
        }
    }
}
