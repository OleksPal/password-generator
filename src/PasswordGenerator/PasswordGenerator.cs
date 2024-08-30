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
            var stringSymbol = symbol.ToString();

            replacement.Replacements.TryGetValue(stringSymbol, out List<string> replacementOptions);
            if (replacementOptions is null)
                replacementOptions = new List<string> { stringSymbol };
            else
                replacementOptions.Add(stringSymbol);

            return replacementOptions[random.Next(replacementOptions.Count)];            
        }

        public string GenerateMemorablePassword(string userKeywords)
        {
            if (userKeywords is null)
                return String.Empty;

            userKeywords = String.Concat(userKeywords.Where(c => !char.IsWhiteSpace(c)));
            string password = String.Empty;

            BigLettersReplacements bigLettersReplacements = new();
            SmallLettersReplacements smallLettersReplacements = new();
            NumbersReplacements numbersReplacements = new();

            foreach (var symbol in userKeywords)
            {
                if (Char.IsLower(symbol))
                    password += MakeCharacterReplacement(smallLettersReplacements, symbol);
                else if (Char.IsUpper(symbol))
                    password += MakeCharacterReplacement(bigLettersReplacements, symbol);
                else if (Char.IsDigit(symbol))
                    password += MakeCharacterReplacement(numbersReplacements, symbol);
                else
                    password += symbol;
            }

            return password;
        }
    }
}
