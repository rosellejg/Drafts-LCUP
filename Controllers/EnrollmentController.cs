using LCUP.Data;
using LCUP.Models.Entity;
using LCUP.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using System.Diagnostics.Eventing.Reader;

namespace LCUP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrollmentController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        public EnrollmentController(ApplicationDbContext applicationDBContext)
        {
            this.dbContext = applicationDBContext;

        }

        [HttpPost("Registration")]
        public IActionResult CreateStudentInfo(Application_FormDTO application_FormDTO)
        {
            var CreateStudent = new ApplicationFormDB()
            {
                Student_Id = application_FormDTO.Student_Id,
                FirstName = application_FormDTO.FirstName,
                MiddleName = application_FormDTO.MiddleName,
                Nickname = application_FormDTO.Nickname,
                LastName = application_FormDTO.LastName,
                BirthDate = application_FormDTO.BirthDate,
                Age = application_FormDTO.Age,
                Sex = application_FormDTO.Sex,
                Citizenship = application_FormDTO.Citizenship,
                Religion = application_FormDTO.Religion,
                Birth_Place = application_FormDTO.Birth_Place,
                Birth_Order = application_FormDTO.Birth_Order,
                Email = application_FormDTO.Email,
                Present_Address = application_FormDTO.Present_Address,
                Landline_Number = application_FormDTO.Landline_Number,
                Mobile_Number = application_FormDTO.Mobile_Number,
                Permanent_Address = application_FormDTO.Permanent_Address,
                GenAvgRank = application_FormDTO.GenAvgRank,
                Graduation_Date = application_FormDTO.Graduation_Date,
                Talent_Skills = application_FormDTO.Talent_Skills,
                Hobbies_Interests = application_FormDTO.Hobbies_Interests,
                Language_Spoken = application_FormDTO.Language_Spoken
            };


            dbContext.PersonalData.Add(CreateStudent);
            dbContext.SaveChanges();

            return Ok(new
            {
                Message = "Successfully Submitted your Personal Data",
                Data = application_FormDTO
            });
        }


        [HttpGet("GetStudentInformationbyID")] //left join for sql query
        public IActionResult getstudentbyID(int Student_Id)
        {

            var StudentInformation = dbContext.PersonalData.Find(Student_Id); //searching only for primary keys.
            var FamilyBackground = dbContext.Family_Background.FirstOrDefault(x => x.Student_Id == Student_Id); //for searching by other columns.
            if (StudentInformation is not null)
            {
                return Ok(new
                {

                    Message = "Student Id exists",
                    Data = StudentInformation, FamilyBackground
                });
            }

            return NotFound("Student not found");
        }

        [HttpPost("FamilyBackground")]
        public IActionResult ApplicationForm2(Application_FormDTO_FamilyBG familyBG)
        {
            var createfambg = new ApplicationFormDB2 ()
            {
                Student_Id = familyBG.Student_Id,
                FullName = familyBG.FullName,
                Citizenship = familyBG.Citizenship,
                Religion = familyBG.Religion,
                Birth_Place = familyBG.Birth_Place,
                Age = familyBG.Age,
                BirthDate = familyBG.BirthDate,
                Highest_Education_Attainment = familyBG.Highest_Education_Attainment,
                School_Graduated_Form = familyBG.School_Graduated_Form,
                Present_Address = familyBG.Present_Address,
                Mobile_Number = familyBG.Mobile_Number,
                Email = familyBG.Email,
                Occupational = familyBG.Occupational,
                Employer = familyBG.Occupational,
                Bussiness_Address = familyBG.Bussiness_Address,
                Annual_Income = familyBG.Annual_Income

            };

            dbContext.Family_Background.Add(createfambg);
            dbContext.SaveChanges();

            return Ok(new
            {
                Message = "Family Background successfully created!",
                Data = familyBG

            });
        }

        [HttpPost("EmergencyContact")]
        public IActionResult EmergencyContact (EmergencyContact emergency)
        {

            var emergency_contact = new ApplicationFormDB3()
            {
                Entity_Id = emergency.Entity_Id,
                FullName = emergency.FullName,
                Relationship = emergency.Relationship,
                Contact_Number = emergency.Contact_Number,
                Email = emergency.Email,
                Present_Address = emergency.Present_Address,
            };

            dbContext.Emergency_Contact.Add(emergency_contact); 
            dbContext.SaveChanges();

            return Ok(emergency);
         
        }
    }
       
        
    }


  
