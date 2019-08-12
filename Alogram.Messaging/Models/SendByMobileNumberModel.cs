using System;
using System.Collections.Generic;
using System.Text;

namespace Alogram.Messaging.Models
{
    public class SendByMobileNumberModel
    {
        public string Message { get; set; }
        public List<string> MobileNumbers { get; set; }
        public bool CanContinueInCaseOfError { get; set; }
    }
}
