namespace Final18
{
    /// <summary>
    /// Класс отправитель команды.
    /// </summary>
    class Sender
    {
        Command command;

        /// <summary>
        /// Устанавливает текущий объект команды.
        /// </summary>
        /// <param name="command"></param>
        public void SetCommand(Command command)
        {
            this.command = command;
        }

        /// <summary>
        /// Выполняет команду.
        /// </summary>
        public void Run()
        {
            command.Run();
        }
    }
}