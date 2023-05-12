using CalastoneInterviewExercise.Filter;

namespace CalastoneInterviewExerciseTests
{
    public class FilterServiceTests
    {
        private readonly FilterService _filterService;
        public FilterServiceTests()
        {
            _filterService = new FilterService();
        }

        [Fact]
        public void ContainsLessThanThreeLettersWord_WhenWordMoreThan3Letters_ShouldReturnFalse()
        {
            //Arrange
            var word = "By";

            //Act
            var result = _filterService.ContainsLessThanThreeLettersWord(word);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void ContainsLessThanThreeLettersWord_WhenWordHasLessThanThreeLetters_ShouldReturnTrue()
        {
            //Arrange
            var word = "calastone";

            //Act
            var result = _filterService.ContainsLessThanThreeLettersWord(word);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void ContainsLessThanThreeLettersWord_WhenStringIsNullOrEmpty_ShouldReturnFalse()
        {
            //Arrange
            var word = string.Empty;

            //Act
            var result = _filterService.ContainsLessThanThreeLettersWord(word);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void ContainsTchar_WhenWordContainsLetterT_ShouldReturnTrue()
        {
            //Arrange
            var word = "The";

            //Act
            var result = _filterService.ContainsTchar(word);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void ContainsTchar_WhenWordDoesNotContainLetterT_ShouldReturnFalse()
        {
            //Arrange
            var word = "was";

            //Act
            var result = _filterService.ContainsTchar(word);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void ContainsTchar_WhenStringIsNullOrEmpty_ShouldReturnFalse()
        {
            //Arrange
            var word = string.Empty;

            //Act
            var result = _filterService.ContainsTchar(word);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void ContainsVowelInTheMiddle_WhenStringIsNullOrEmpty_ShouldReturnFalse()
        {
            //Arrange
            var word = string.Empty;

            //Act
            var result = _filterService.ContainsVowelInTheMiddle(word);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void ContainsVowelInTheMiddle_WhenWordContainsVowelInTheMiddle_ShouldReturnTrue()
        {
            //Arrange
            var word = "currently";

            //Act
            var result = _filterService.ContainsVowelInTheMiddle(word);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void ContainsVowelInTheMiddle_WhenWordContainsVowelAtTheEndOfTheWord_ShouldReturnFalse()
        {
            //Arrange
            var word = "the";

            //Act
            var result = _filterService.ContainsVowelInTheMiddle(word);

            //Assert
            Assert.False(result);
        }
    }
}