namespace CalastoneInterviewExercise.Filter
{
    public class FilterService : IFilterService
    {
        public bool ContainsLessThanThreeLettersWord(string word)
        {
            if (!string.IsNullOrEmpty(word))
            {
                return word.Length <= 3;
            }
            return false;
        }

        public bool ContainsTchar(string word)
        {
            if (!string.IsNullOrEmpty(word))
            {
                return word.ToLower().Contains('t');
            }
            return false;
        }

        public bool ContainsVowelInTheMiddle(string word)
        {
            if (!string.IsNullOrEmpty(word))
            {
                char[] vowel = { 'a', 'e', 'i', 'o', 'u' };

                var middle = word.Length / 2;
                var textArray = word.ToLower().ToCharArray();

                foreach (var ch in vowel)
                {
                    if (word.Length > 2) // Assumption: I am only interested in words that has 3 or more letters i.e. "was" [w][a][s] ([a] is a vowel and its in the  middle)
                    {
                        if (textArray[middle - 1] == ch || (textArray[middle] == ch && word.Length >= 3))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
