using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTech.Business.Services
{
    public class SendingMessageService : ISendingMessageService
    {

        SolidTechContext _context;

        public SendingMessageService(SolidTechContext context)
        {
            _context = context;
        }

        public List<SendingMessage> getAllSendingMessage()
        {
           return _context.SendingMessages.ToList();
        }
    }
}
