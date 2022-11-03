using System.Threading.Tasks;

namespace Final18
{
    class Program
    {
        static void Main(string[] args)
        {
            //отправитель команды
            Sender sender = new Sender();

            //получатель команды
            FileOperations reseiver = new FileOperations();

            //команда 1
            CommandGetInformation commandGetInformation = new CommandGetInformation(reseiver);

            sender.SetCommand(commandGetInformation);
            sender.Run();

            //команда 2
            CommandDownload commandDownload = new CommandDownload(reseiver);

            sender.SetCommand(commandDownload);
            sender.Run();
        }
    }
}