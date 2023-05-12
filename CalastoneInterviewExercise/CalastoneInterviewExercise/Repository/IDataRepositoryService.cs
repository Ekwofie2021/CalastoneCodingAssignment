namespace CalastoneInterviewExercise.Repository
{
    public interface IDataRepositoryService
    {
        IEnumerable<string> GetData(string path);
    }
}
