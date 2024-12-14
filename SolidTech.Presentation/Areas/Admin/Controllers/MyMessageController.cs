using Microsoft.AspNetCore.Mvc;

namespace SolidTech.Presentation.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MyMessageController : Controller
    {
        IMessageService _messageService;
        ISendingMessageService _sendingMessageService;
     
        public MyMessageController(IMessageService messageService,ISendingMessageService sendingMessageService)
        {
            _messageService = messageService;
            _sendingMessageService = sendingMessageService;
        }


       
        public IActionResult Index()
        {
            var MessageList = _messageService.Messages();

            return View(MessageList);
        }


        [HttpGet]
        public IActionResult ViewMessageDetail(int message_id)
        {

            var message = _messageService.GetMessageById(message_id);

            if (message != null)
            {
                return View(message);
            }


            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult ViewSendingMessages()
        {
            var result = _sendingMessageService.getAllSendingMessage();


            return View(result);
        }

       



    }
}
