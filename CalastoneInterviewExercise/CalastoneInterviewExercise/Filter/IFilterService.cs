namespace CalastoneInterviewExercise.Filter
{
    public interface IFilterService
    {
        bool ContainsLessThanThreeLettersWord(string word);
        bool ContainsTchar(string word);
        bool ContainsVowelInTheMiddle(string word);
    }
}