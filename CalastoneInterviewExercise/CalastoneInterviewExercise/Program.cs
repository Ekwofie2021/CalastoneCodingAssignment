// See https://aka.ms/new-console-template for more information
using CalastoneInterviewExercise.Filter;
using CalastoneInterviewExercise.Repository;

var dataRepository = new DataRepositoryService(new DataService(new FileManager(), new FilterService()));

foreach (var word in dataRepository.GetData("Repository//calastoneTextInput.txt"))
{
    Console.WriteLine(word);
}