using PasswordGeneratorApp.Generator;
using PasswordGeneratorApp.Const;
using UnitTests;

namespace PasswordGeneratorApp.UnitTests
{
    public class PasswordGeneratorTests
    {
        private readonly IPasswordGeneratable passwordGenerator;

        public PasswordGeneratorTests()
        {
            passwordGenerator = Helper.GetServiceProvider<IPasswordGeneratable>();
        }

        [Fact]
        public void DefaultVocabularyEqualsLetters()
        {
            Assert.Equal(Constants.Letters, passwordGenerator.Vocabulary);
        }

        #region GenerateNonMemorablePassword method
        [Fact]
        public void GenerateNonMemorablePasswordWithNegativeLength()
        {
            string password = passwordGenerator.GenerateNonMemorablePassword(-5);

            Assert.Empty(password);
        }

        [Fact]
        public void GenerateNonMemorablePasswordWithZeroLength()
        {
            string password = passwordGenerator.GenerateNonMemorablePassword(0);

            Assert.Empty(password);
        }

        [Fact]
        public void GenerateNonMemorablePasswordWithPositiveLength()
        {
            string password = passwordGenerator.GenerateNonMemorablePassword(10);

            Assert.NotNull(password);
        }

        [Fact]
        public void GenerateNonMemorablePasswordWithNumbers()
        {
            passwordGenerator.Vocabulary += Constants.Numbers;

            string password = passwordGenerator.GenerateNonMemorablePassword(10);

            bool isContainsNumbers = password.Any(symbol => Constants.Numbers.Contains(symbol));
            Assert.True(isContainsNumbers);
        }

        [Fact]
        public void GenerateNonMemorablePasswordWithSpecialSymbols()
        {
            passwordGenerator.Vocabulary += Constants.SpecialSymbols;

            string password = passwordGenerator.GenerateNonMemorablePassword(10);

            bool isContainsSpecialSymbols = password.Any(symbol => Constants.SpecialSymbols.Contains(symbol));
            Assert.True(isContainsSpecialSymbols);
        }

        [Fact]
        public void GenerateNonMemorablePasswordWithNumbersAndSpecialSymbols()
        {
            passwordGenerator.Vocabulary += Constants.Numbers;
            passwordGenerator.Vocabulary += Constants.SpecialSymbols;

            string password = passwordGenerator.GenerateNonMemorablePassword(10);

            bool isContainsNumbers = password.Any(symbol => Constants.Numbers.Contains(symbol));
            bool isContainsSpecialSymbols = password.Any(symbol => Constants.SpecialSymbols.Contains(symbol));

            Assert.True(isContainsNumbers && isContainsSpecialSymbols);
        }
        #endregion

        #region GenerateMemorablePassword method
        [Fact]
        public void GenerateMemorablePasswordWithNullKeyword()
        {
            string keywords = null;

            string password = passwordGenerator.GenerateMemorablePassword(keywords);

            Assert.Empty(password);
        }

        [Fact]
        public void GenerateMemorablePasswordWithEmptyStringKeyword()
        {
            var keywords = String.Empty;

            string password = passwordGenerator.GenerateMemorablePassword(keywords);

            Assert.Empty(password);
        }

        [Fact]
        public void GenerateMemorablePasswordWithValidKeywords()
        {
            var keywords = "String Empty";

            string password = passwordGenerator.GenerateMemorablePassword(keywords);

            Assert.NotEmpty(password);
        }
        #endregion
    }
}