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
            if (Vocabulary.Any(ch => !char.IsLetterOrDigit(ch)))
                symbolTypes.Add("SpecialSymbols");

            for (int i = 0; i < passwordSize; i++)
            {
                var nextSymbolType = symbolTypes[random.Next(symbolTypes.Count)];
                switch (nextSymbolType)
                {
                    case "Letters":
                        password += Constants.Letters[random.Next(Constants.Letters.Length)];
                        break;
                    case "Numbers":
                        password += Constants.Numbers[random.Next(Constants.Numbers.Length)];
                        break;
                    case "SpecialSymbols":
                        password += Constants.SpecialSymbols[random.Next(Constants.SpecialSymbols.Length)];
                        break;
                }
            }

            return password;
        }

        private string MakeCharacterReplacement(Replacement replacement, char symbol)
        {
            for (int i = 0; i < replacement.Replacements.Length; i++)
            {
                if (symbol.ToString() == replacement.Replacements[i].First())
                {
                    if (replacement.Replacements[i].Length == 1)
                        return replacement.Replacements[i].First();
                    else
                        return replacement.Replacements[i][random.Next(replacement.Replacements[i].Length)];
                }
            }

            return String.Empty;
        }

        public string GenerateMemorablePassword(string userKeywords)
        {
            userKeywords = String.Concat(userKeywords.Where(c => !Char.IsWhiteSpace(c)));
            string password = String.Empty;

            BigLettersReplacements bld = new();
            SmallLettersReplacements sld = new();
            NumbersReplacements nd = new();

            foreach (char symbol in userKeywords)
            {
                if (char.IsLower(symbol))
                    password += MakeCharacterReplacement(sld, symbol);
                else if (char.IsUpper(symbol))
                    password += MakeCharacterReplacement(bld, symbol);
                else if (char.IsDigit(symbol))
                    password += MakeCharacterReplacement(nd, symbol);
                else
                    password += symbol;
            }

            return password;
        }
    }
}
