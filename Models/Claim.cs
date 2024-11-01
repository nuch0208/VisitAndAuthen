using System.ComponentModel.DataAnnotations;

namespace VisitAndAuthen.Models
{
    public class Claim
    {
        [Required(ErrorMessage = "จำเป็นต้องกรอกข้อมูลให้ครบ")]        
        public string Cid {get; set;}
        [Required(ErrorMessage = "จำเป็นต้องกรอกข้อมูลให้ครบ")] 
        public string ClaimType {get; set;}
        [Required(ErrorMessage = "จำเป็นต้องกรอกข้อมูลให้ครบ")] 
        public string Hometel {get; set;}
        [Required(ErrorMessage = "จำเป็นต้องกรอกข้อมูลให้ครบ")] 
        public string CorrelationId {get; set;}
        [Required(ErrorMessage = "จำเป็นต้องกรอกข้อมูลให้ครบ")] 
        public string Hn {get; set;}
        [Required(ErrorMessage = "จำเป็นต้องกรอกข้อมูลให้ครบ")] 
        public string Hcode {get; set;}
    }
}