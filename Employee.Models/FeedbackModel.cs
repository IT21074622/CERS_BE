using System;
using System.Collections.Generic;
using System.Text;

namespace Employee.Models
{
    public class FeedbackModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int PIN { get; set; }
        public string Type { get; set; }
        public string InquiryType { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string PhotoFileName { get; set; }
    }
}
