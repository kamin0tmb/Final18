using System;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace Final18
{
    /// <summary>
    /// Класс для работы с файлами YouTube.
    /// </summary>
    class FileOperations
    {
        string pathFile;

        /// <summary>
        /// Получает информацию о файле.
        /// </summary>
        public void GetInformation()
        {
            Console.Write("Введите ссылку на файл: ");

            pathFile = Console.ReadLine();

            var video = RequestToYouTube(pathFile);

            Console.WriteLine();
            Console.WriteLine("Название: " + video.Result.Title);
            Console.WriteLine("Автор: " + video.Result.Author);
            Console.WriteLine("Продолжительность: " + video.Result.Duration);
        }

        private async Task<YoutubeExplode.Videos.Video> RequestToYouTube(string pathFile)
        {
            Console.WriteLine("Получаем информацию...");

            var youtube = new YoutubeClient();

            return await youtube.Videos.GetAsync(pathFile);
        }

        /// <summary>
        /// Скачивает файл.
        /// </summary>
        public void DownloadFile()
        {
            Console.WriteLine();

            IAsyncResult result = Download();

            while (result.IsCompleted != true) { }

            Console.WriteLine();
            Console.WriteLine("Загрузка завершена.");
        }

        private async Task Download()
        {
            Console.WriteLine("Загружаем файл...");
            Console.WriteLine("(дождитесь сообщения о завершении загрузки)");

            var youtube = new YoutubeClient();

            await youtube.Videos.DownloadAsync(pathFile, "video.mp4", builder => builder.SetPreset(ConversionPreset.UltraFast));
        }
    }
}