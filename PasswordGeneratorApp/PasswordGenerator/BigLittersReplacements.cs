namespace PasswordGeneratorApp
{
    public class BigLittersReplacements : Replacement
    {
        public override string[][] Replacements
        {
            get
            {
                string[][] _replacements =
                {
                    new[] { @"A", @"/-\", @"/=\", @"/~\" },
                    new[] { @"B", @"|3" },
                    new[] { @"C" },
                    new[] { @"D", @"|)", @"|]", @"|}", @"!)", @"!]", @"!}" },
                    new[] { @"E" },
                    new[] { @"F" },
                    new[] { @"G", @"6" },
                    new[] { @"H", @"|-|", @"|=|", @"!-!", @"!=!", @"!-|", @"|=!" },
                    new[] { @"I", @"1", @"|" },
                    new[] { @"J", @"_|", @"_]", @"_)", @"]", @"_}" },
                    new[] { @"K", @"|<" },
                    new[] { @"L", @"|_", @"(_", @"[_", @"{_" },
                    new[] { @"M", @"|\/|", @"[\/]", @"{\/}", @"(\/|", @"!\/}" },
                    new[] { @"N", @"|\|", @"!\|", @"|\!" },
                    new[] { @"O", @"0" },
                    new[] { @"P", @"|^", @"|*" },
                    new[] { @"Q", @"O,", @"0," },
                    new[] { @"R" },
                    new[] { @"S", @"5" },
                    new[] { @"T" },
                    new[] { @"U" },
                    new[] { @"V", @"\/" },
                    new[] { @"W", @"\/\/" },
                    new[] { @"X" },
                    new[] { @"Y" },
                    new[] { @"Z" }
                };

                return _replacements;
            }
        }
    }
}

