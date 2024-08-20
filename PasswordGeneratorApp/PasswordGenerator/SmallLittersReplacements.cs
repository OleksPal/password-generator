namespace PasswordGeneratorApp
{
    class SmallLittersReplacements : Replacement
    {
        public override string[][] Replacements
        {
            get
            {
                string[][] _replacemets =
                {
                    new[] {@"a"},
                    new[] {@"b", @"|o", @"!o"},
                    new[] {@"c"},
                    new[] {@"d", @"o|", @"o!"},
                    new[] {@"e"},
                    new[] {@"f"},
                    new[] {@"g", @"8"},
                    new[] {@"h"},
                    new[] {@"i"},
                    new[] {@"j"},
                    new[] {@"k", @"|<"},
                    new[] {@"l", @"|", @"1"},
                    new[] {@"m"},
                    new[] {@"n"},
                    new[] {@"o", @"0"},
                    new[] {@"p", @"|^", @"|*"},
                    new[] {@"q", @"9"},
                    new[] {@"r"},
                    new[] {@"s", @"5"},
                    new[] {@"t"},
                    new[] {@"u"},
                    new[] {@"v", @"\/"},
                    new[] {@"w", @"\/\/"},
                    new[] {@"x"},
                    new[] {@"y"},
                    new[] {@"z"}
                };

                return _replacemets;
            }
        }
    }
}