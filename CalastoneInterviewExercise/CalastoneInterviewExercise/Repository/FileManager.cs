
namespace CalastoneInterviewExercise.Repository
{
    public class FileManager : IFileManager
    {
        public StreamReader StreamReader(string path)
        {
            return new StreamReader(path);
        }
    }
}
