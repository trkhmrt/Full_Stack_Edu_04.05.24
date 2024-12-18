namespace SolidTech.Presentation.Areas.Admin.Components
{
    public class MailPartViewComponent:ViewComponent
    {
        IMessageService _messageService;
   

        public MailPartViewComponent(IMessageService messageService)
        {
            _messageService = messageService;
          
        }

        public IViewComponentResult Invoke(string messageType="inbox")
        {

            List<MessageDto> messages;
           

            if (messageType == "inbox")
            {
                messages = _messageService.GetMessagesByTypeId(1);
            }
            else
            {
                messages = _messageService.GetMessagesByTypeId(2);
            }
            

            return View(messages);
        }




    }
}
