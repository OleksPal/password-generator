namespace PasswordGeneratorApp
{
    class NumbersReplacements : Replacement
    {
        public override string[][] Replacements { 
            get
            {
                string[][] _replacements =
                {
                    new[] {@"0", @"O", @"o"},
                    new[] {@"1", @"!", @"|", @"I", @"i"},
                    new[] {@"2", @"?", @"Z", @"z"},
                    new[] {@"3", @"M", @"m"},
                    new[] {@"4", @"h"},
                    new[] {@"5", @"S", "s"},
                    new[] {@"6", @"G"},
                    new[] {@"7"},
                    new[] {@"8", @"&", @"g"},
                    new[] {@"9"}
                };

                return _replacements;
            } 
        }
    }
}