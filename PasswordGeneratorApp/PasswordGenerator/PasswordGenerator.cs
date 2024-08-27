using PasswordGeneratorApp.Const;
using System;
using System.Collections.Generic;
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

            List<string> symbolTypes = new List<string>() { "Letters" };

            if (Vocabulary.Any(char.IsDigit))
                symbolTypes.Add("Numbers");
            else if (Vocabulary.Any(char.IsPunctuation))
                symbolTypes.Add("SpecialSymbols");

            for (int i = 0; i < passwordSize; i++)
            {
                var nextSymbolType = symbolTypes[random.Next(symbolTypes.Count)];
                switch (nextSymbolType)
                {
                    case "Letters":
                        password += Constants.Letters[random.Next(Constants.Letters.Count())];
                        break;
                    case "Numbers":
                        password += Constants.Numbers[random.Next(Constants.Numbers.Count())];
                        break;
                    case "SpecialSymbols":
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
