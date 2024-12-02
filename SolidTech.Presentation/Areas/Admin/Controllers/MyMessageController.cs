using Microsoft.AspNetCore.Mvc;

namespace SolidTech.Presentation.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MyMessageController : Controller
    {
        IMessageService _messageService;

     
        public MyMessageController(IMessageService messageService)
        {
            _messageService = messageService;
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




    }
}
