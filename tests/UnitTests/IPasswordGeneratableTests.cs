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
        public void Vocabulary_Default_EqualsLetters()
        {
            Assert.Equal(Constants.Letters, passwordGenerator.Vocabulary);
        }

        #region GenerateNonMemorablePassword method
        [Fact]
        public void GenerateNonMemorablePassword_NegativeLength_ReturnsEmpty()
        {
            string password = passwordGenerator.GenerateNonMemorablePassword(-5);

            Assert.Empty(password);
        }

        [Fact]
        public void GenerateNonMemorablePassword_ZeroLength_ReturnsEmpty()
        {
            string password = passwordGenerator.GenerateNonMemorablePassword(0);

            Assert.Empty(password);
        }

        [Fact]
        public void GenerateNonMemorablePassword_PositiveLength_ReturnsNotNull()
        {
            string password = passwordGenerator.GenerateNonMemorablePassword(10);

            Assert.NotNull(password);
        }

        [Fact]
        public void GenerateNonMemorablePassword_AllowNumbers_ReturnsStringWithNumbers()
        {
            passwordGenerator.Vocabulary += Constants.Numbers;

            string password = passwordGenerator.GenerateNonMemorablePassword(10);

            bool isContainsNumbers = password.Any(symbol => Constants.Numbers.Contains(symbol));
            Assert.True(isContainsNumbers);
        }

        [Fact]
        public void GenerateNonMemorablePassword_AllowSpecialSymbols_ReturnsStringWithSpecialSymbols()
        {
            passwordGenerator.Vocabulary += Constants.SpecialSymbols;

            string password = passwordGenerator.GenerateNonMemorablePassword(10);

            bool isContainsSpecialSymbols = password.Any(symbol => Constants.SpecialSymbols.Contains(symbol));
            Assert.True(isContainsSpecialSymbols);
        }

        [Fact]
        public void GenerateNonMemorablePassword_AllowNumbersAndSpecialSymbols_ReturnsStringWithAllKindOfSymbols()
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
        public void GenerateMemorablePassword_Null_ReturnsEmpty()
        {
            string keywords = null;

            string password = passwordGenerator.GenerateMemorablePassword(keywords);

            Assert.Empty(password);
        }

        [Fact]
        public void GenerateMemorablePassword_EmptyString_ReturnsEmpty()
        {
            var keywords = String.Empty;

            string password = passwordGenerator.GenerateMemorablePassword(keywords);

            Assert.Empty(password);
        }

        [Theory]
        [InlineData("a")]
        [InlineData("1")]
        [InlineData("/")]
        [InlineData("Some Keywords")]
        public void GenerateMemorablePassword_SomeValidString_ReturnsNotEmpty(string keywords)
        {
            string password = passwordGenerator.GenerateMemorablePassword(keywords);

            Assert.NotEmpty(password);
        }
        #endregion
    }
}