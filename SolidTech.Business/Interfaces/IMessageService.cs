namespace SolidTech.Business.Interfaces
{
    public interface IMessageService
    {
        List<MessageDto> Messages();

        Message GetMessageById(int id);

        int AddMessage(MessageDto messageDto);
    }

}