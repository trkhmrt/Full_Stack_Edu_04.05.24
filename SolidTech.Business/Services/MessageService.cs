namespace SolidTech.Business.Services
{
    public class MessageService : IMessageService
    {
        private readonly SolidTechContext _context;//DI
        private readonly IMapper _mapper;
        public MessageService(SolidTechContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<MessageDto> Messages()
        {
            List<Message> messages = _context.Messages.ToList();
            List<MessageDto> messageDtos = _mapper.Map<List<MessageDto>>(messages);
            return messageDtos;
        }

        public int AddMessage(MessageDto messageDto)
        {
            Message message = _mapper.Map<Message>(messageDto);

            _context.Messages.Add(message);
            return _context.SaveChanges();
        }

        public Message GetMessageById(int id)
        {
            var message = _context.Messages.FirstOrDefault(m => m.MessageId == id);

            if (message != null)
            {

                return message;
            }

            return null;

        }

        public List<MessageDto> GetMessagesByTypeId(int typeId)
        {
            var result = _context.Messages.Where(m => m.MessageTypeId == typeId).ToList();
            List<MessageDto> inbox_messages = _mapper.Map<List<MessageDto>>(result);

            return inbox_messages;
        }

    
    }


}
