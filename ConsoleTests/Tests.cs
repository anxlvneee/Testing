namespace ConsoleTests
{
    public class Tests
    {
        [Fact]
        public void Guess_ShouldReturnMore_WhenGuessIsLessThanNumber()
        {
            // Arrange
            var game = new GuessNumber(50);

            // Act
            var result = game.Guess(30);

            // Assert
            Assert.Equal("Бiльше", result);
        }

        [Fact]
        public void Guess_ShouldReturnLess_WhenGuessIsGreaterThanNumber()
        {
            // Arrange
            var game = new GuessNumber(50);

            // Act
            var result = game.Guess(80);

            // Assert
            Assert.Equal("Менше", result);
        }

        [Fact]
        public void Guess_ShouldReturnCorrectMessage_WhenGuessIsEqualToNumber()
        {
            // Arrange
            var game = new GuessNumber(50);

            // Act
            var result = game.Guess(50);

            // Assert
            Assert.Contains("Вiрно!", result);
        }

        [Fact]
        public void GetAttempts_ShouldReturnCorrectAttemptsCount()
        {
            // Arrange
            var game = new GuessNumber(50);

            // Act
            game.Guess(30);
            game.Guess(50);

            // Assert
            Assert.Equal(2, game.GetAttempts());
        }

        [Fact]
        public void Guess_ShouldHandleInvalidInputGracefully()
        {
            // Arrange
            var game = new GuessNumber(50);
            string userInput = "abc";

            // Act
            bool isValidInput = int.TryParse(userInput, out int userGuess);

            // Assert
            Assert.False(isValidInput);
        }

        [Fact]
        public void Guess_ShouldHandleBoundaryValues()
        {
            // Arrange
            var gameMin = new GuessNumber(1);
            var gameMax = new GuessNumber(100);

            // Act
            var resultMin = gameMin.Guess(1);
            var resultMax = gameMax.Guess(100);

            // Assert
            Assert.Contains("Вiрно!", resultMin); 
            Assert.Contains("Вiрно!", resultMax);
        }
    }
}