using System;
using System.Collections.Generic;
using System.Text;

namespace Alogram.Messaging.Models
{
    public class AddContactResultModel:Response
    {
        public List<ContactsDetailModel> AddedList { get; set; }
        public List<ContactsDetailModel> ErroneousList { get; set; }
    }
    
}
