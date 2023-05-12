using CalastoneInterviewExercise.Filter;
using CalastoneInterviewExercise.Repository;
using FluentAssertions;
using Moq;
using System.Text;

namespace CalastoneInterviewExerciseTests
{
    public class DataServiceTests
    {
        [Fact]
        public void ProcessData_WhenFileExistWithData_ShouldReturnProcessedData()
        {
            // Arrange
            var mockFilterService = new Mock<FilterService>();
            var mockFileManager = new Mock<IFileManager>();

            var expectedWord = "remarkable";
            var fileData = "There was nothing so very remarkable in that;";

            byte[] fileDataBytes = Encoding.UTF8.GetBytes(fileData);
            var mockMemoryStream = new MemoryStream(fileDataBytes);

            mockFileManager.Setup(fileManager => fileManager.StreamReader(It.IsAny<string>()))
                .Returns(() => new StreamReader(mockMemoryStream));

            // Act
            var dataService = new DataService(mockFileManager.Object, mockFilterService.Object);

            var result = dataService.ProcessData("test.txt");

            // Assert
            result.Should().BeEquivalentTo(expectedWord);
        }

        [Fact]
        public void ProcessData_WhenGivenFilePathIsWhitespace_ShouldThrowNullReferenceException()
        {
            // Arrange
            var mockFilterService = new Mock<FilterService>();
            var mockFileManager = new Mock<IFileManager>();

            // Act
            var dataService = new DataService(mockFileManager.Object, mockFilterService.Object);

            Action act = () => dataService.ProcessData("");

            // Assert
            act.Should().Throw<NullReferenceException>();       
        }
    }
}
