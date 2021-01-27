/*< !--Preston Loveland
     Assignment 1 IS 414
    Group 11 Section 1-->*/
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstASPNETWebApp.Models
{
    //class to gather grade attributes and validate info entry
    public class GradeCalculatorModel
    {
        [Required, Range(0, 100)]
        public int assignments { get; set; }
        [Required, Range(0, 100)]
        public int group_project { get; set; }
        [Required, Range(0, 100)]
        public int quizzes { get; set; }
        [Required, Range(0, 100)]
        public int exams { get; set; }
        [Required, Range(0, 100)]
        public int intex { get; set; }
    }
}