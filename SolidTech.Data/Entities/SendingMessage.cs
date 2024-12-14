using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTech.Data.Entities
{
    public class SendingMessage : BaseEntity
    {
        public int SendingMessageId { get; set; }
        public required string SendToEmail { get; set; }
        public required string MessageHeader { get; set; }
        public required string MessageContent { get; set; }


    }
}
