namespace Rogue.Chat.Ui.Messages;

public class Message
{
    
    public Message(string username, string body, bool isMine)
    {
        Username = username;
        Body = body;
        IsMine = isMine;
    }

    public string Username { get; set; }
    public string Body { get; set; }
    public bool IsMine { get; set; }
}