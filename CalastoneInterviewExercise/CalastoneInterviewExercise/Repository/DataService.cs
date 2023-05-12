using CalastoneInterviewExercise.Filter;

namespace CalastoneInterviewExercise.Repository
{
    public class DataService : IDataService
    {
        private readonly IFileManager _fileManager;
        private readonly IFilterService _filterService;

        public DataService(IFileManager dataManager, IFilterService filterService)
        {
            _fileManager = dataManager;
            _filterService = filterService;
        }

        public IEnumerable<string> ProcessData(string filePath)
        {
            var data = new List<string>();

            try
            {
                using (var reader = _fileManager.StreamReader(Path.Combine(Environment.CurrentDirectory, filePath)))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        if (line != null)
                        {
                            foreach (var word in line.Split(new[] { ' ', '\t', '\'', '-', ':', ',', '!', '?', '"', ';', '—', '‘', '’', ',', ')', '(', '.' })) //could be improve using: Regex); 
                            {
                                if (!string.IsNullOrWhiteSpace(word) && PassRequiredFilter(word))
                                {
                                    data.Add(word);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _ = ex switch
                {
                    ArgumentNullException => throw new ArgumentNullException("Please provide file name, null is not allow"),
                    NullReferenceException => throw new NullReferenceException("Please provide file name, whitespace is not allow"),
                    FileNotFoundException => throw new FileNotFoundException($"The given File: {filePath} does not exit!"),
                    _ => "Unknown Exception!"
                };
            }

            return data;
        }

        private bool PassRequiredFilter(string word)
        {
            return !(_filterService.ContainsLessThanThreeLettersWord(word) ||
                   _filterService.ContainsTchar(word) ||
                   _filterService.ContainsVowelInTheMiddle(word));
        }
    }
}