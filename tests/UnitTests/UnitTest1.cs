using PasswordGeneratorApp.Generator;
using PasswordGeneratorApp.Const;

namespace PasswordGeneratorApp.UnitTests
{
    public class PasswordGeneratorTests
    {
        [Fact]
        public void DefaultVocabularyEqualsLetters()
        {
            IPasswordGeneratable passwordGenerator = new PasswordGenerator();

            Assert.Equal(Constants.Letters, passwordGenerator.Vocabulary);
        }
    }
}