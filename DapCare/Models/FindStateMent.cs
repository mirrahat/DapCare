using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DapCare.Models
{
    public class FindStateMent
    {

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int EmployeId {get;set;}

    }
}