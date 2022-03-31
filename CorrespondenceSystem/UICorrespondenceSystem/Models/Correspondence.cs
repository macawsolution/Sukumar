using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UICorrespondenceSystem.Models
{
    public class Correspondence
    {
        [ScaffoldColumn(false)]
        public int ID { get; set; }


        [Display(Name = "Correspondence Serial Number")]
        [Required(ErrorMessage ="Please enter serial number!.")]
        public string Serial_Number { get; set; }

        [Display(Name ="Correspondence Date")]
        [Required(ErrorMessage = "Please enter/select correspondence date!.")]
        [DataType(DataType.Date)] 

        public DateTime Correspondence_Date { get; set; }

        [Display(Name ="Received Date")] 
        [DataType(DataType.Date)] 

        [Required(ErrorMessage = "Please enter/select received date!.")]
        public DateTime Received_Date { get; set; }

        [Display(Name ="Subject")]
        [Required(ErrorMessage = "Please enter subject!.")]
        public string Subject { get; set; }
        public string Description { get; set; }
        public int Sender_Type { get; set; }
        public int Sender_Internal_ID { get; set; }
        public int Sender_External_ID { get; set; }
        public int Expected_Reply_WithIn_Days { get; set; }

    }

    public class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}