
namespace CalastoneInterviewExercise.Repository
{
    public class DataRepositoryService : IDataRepositoryService
    {
        private readonly IDataService _dataService;

        public DataRepositoryService(IDataService dataService)
        {
            _dataService = dataService;
        }

        public IEnumerable<string> GetData(string path)
        {
            return _dataService.ProcessData(path);
        }
    }
}
