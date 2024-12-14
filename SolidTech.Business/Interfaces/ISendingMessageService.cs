using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTech.Business.Interfaces
{
    public interface ISendingMessageService
    {
        List<SendingMessage> getAllSendingMessage();

    }
}
