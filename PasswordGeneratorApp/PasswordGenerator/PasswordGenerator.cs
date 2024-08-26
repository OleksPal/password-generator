using PasswordGeneratorApp.Const;
using System;
using System.Linq;

namespace PasswordGeneratorApp.Generator
{
    public class PasswordGenerator : IPasswordGeneratable
    {
        private readonly Random random;

        public string Vocabulary { get; set; }

        public PasswordGenerator()
        {
            random = new Random();
            Vocabulary = Constants.Letters;
        }

        public string GenerateNonMemorablePassword(int passwordSize)
        {
            var password = String.Empty;

            //var symbolType = new string[3] { "Letters", "Numbers", "SpecialSymbols" };
            //int optionNumber = 0;
            //if(Vocabulary.n)

            for (int i = 0; i < passwordSize; i++)
            {
                int symbolTypeChoice = random.Next(3);
                switch (symbolTypeChoice)
                {
                    case 0:
                        password += Constants.Letters[random.Next(Constants.Letters.Count())];
                        break;
                    case 1:
                        password += Constants.Numbers[random.Next(Constants.Numbers.Count())];
                        break;
                    case 2:
                        password += Constants.SpecialSymbols[random.Next(Constants.SpecialSymbols.Count())];
                        break;
                }
            }

            return password;
        }

        private string MakeCharacterReplacement(Replacement replacement, char nextRandSymbol)
        {
            for (int j = 0; j < replacement.Replacements.Length; j++)
            {
                if (nextRandSymbol.ToString() == replacement.Replacements[j][0])
                {
                    if (replacement.Replacements[j].Length == 1)
                        return replacement.Replacements[j][0];
                    else
                    return replacement.Replacements[j][random.Next(0, replacement.Replacements[j].Length)];
                }
            }

            return String.Empty;
        }

        public string GenerateMemorablePassword(string userKeywords)
        {
            string passWord = userKeywords;
            passWord = String.Concat(passWord.Where(c => !Char.IsWhiteSpace(c)));
            string result2 = String.Empty;

            BigLettersReplacements bld = new();
            SmallLettersReplacements sld = new();
            NumbersReplacements nd = new();

            foreach (char symbol in passWord)
            {
                if (char.IsLower(symbol))
                    result2 += MakeCharacterReplacement(sld, symbol);
                else if (char.IsUpper(symbol))
                    result2 += MakeCharacterReplacement(bld, symbol);
                else if (char.IsDigit(symbol))
                    result2 += MakeCharacterReplacement(nd, symbol);
                else
                    result2 += symbol;
            }

            return result2;
        }
    }
}
