namespace PasswordGeneratorApp
{
    class NumbersDependencies : IDependencies
    {
        readonly string[][] _numbers =
        {
            new[] {@"0", @"O", @"o"},
            new[] {@"1", @"|", @"I", @"i"},
            new[] {@"2"},
            new[] {@"3"},
            new[] {@"4"},
            new[] {@"5", @"s", "S"},
            new[] {@"6", @"G"},
            new[] {@"7"},
            new[] {@"8", @"g"},
            new[] {@"9"}
        };

        public string[][] GetDependencies()
        {
            return _numbers;
        }
    }
}