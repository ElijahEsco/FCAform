using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesForm.Models
{
    public class Form
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string ChangesMade { get; set; }
        public decimal Refection { get; set; }
    }
}