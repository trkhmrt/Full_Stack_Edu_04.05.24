using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTech.Data.Entities
{
    public class MessageType:BaseEntity
    {
        public int MessageTypeId { get; set; }

        public string MessageTypeName { get; set; }

        public string MessageTypeDescription { get; set; }


    }
}
