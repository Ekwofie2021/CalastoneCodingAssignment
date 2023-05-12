namespace CalastoneInterviewExercise.Repository
{
    public interface IDataService
    {
        IEnumerable<string> ProcessData(string filePath);
    }
}
