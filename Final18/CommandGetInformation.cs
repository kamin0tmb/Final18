namespace Final18
{
    /// <summary>
    /// Класс команды на получение информации о видео.
    /// </summary>
    class CommandGetInformation : Command
    {
        FileOperations reseiver;

        public CommandGetInformation(FileOperations reseiver)
        {
            this.reseiver = reseiver;
        }

        public override void Run()
        {
            reseiver.GetInformation();
        }
    }
}