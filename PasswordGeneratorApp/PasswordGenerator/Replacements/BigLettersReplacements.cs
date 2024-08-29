using System.Collections.Generic;

namespace PasswordGeneratorApp
{
    public class BigLettersReplacements : Replacement
    {
        public override Dictionary<string, List<string>> Replacements
        {
            get
            {
                var _replacements = new Dictionary<string, List<string>>();

                _replacements.TryAdd(@"A", new List<string> { @"/-\", @"/=\", @"/~\" });
                _replacements.TryAdd(@"B", new List<string> { @"|3" });
                _replacements.TryAdd(@"C", null);
                _replacements.TryAdd(@"D", new List<string> { @"|)", @"|]", @"|}", @"!)", @"!]", @"!}" });
                _replacements.TryAdd(@"E", null);
                _replacements.TryAdd(@"F", null);
                _replacements.TryAdd(@"G", new List<string> { @"6" });
                _replacements.TryAdd(@"H", new List<string> { @"|-|", @"|=|", @"!-!", @"!=!", @"!-|", @"|=!" });
                _replacements.TryAdd(@"I", new List<string> { @"1", @"|" });
                _replacements.TryAdd(@"J", new List<string> { @"_|", @"_]", @"_)", @"]", @"_}" });
                _replacements.TryAdd(@"K", new List<string> { @"|<" });
                _replacements.TryAdd(@"L", new List<string> { @"|_", @"(_", @"[_", @"{_" });
                _replacements.TryAdd(@"M", new List<string> { @"|\/|", @"[\/]", @"{\/}", @"(\/|", @"!\/}" });
                _replacements.TryAdd(@"N", new List<string> { @"|\|", @"!\|", @"|\!" });
                _replacements.TryAdd(@"O", new List<string> { @"0" });
                _replacements.TryAdd(@"P", new List<string> { @"|^", @"|*" });
                _replacements.TryAdd(@"Q", new List<string> { @"O,", @"0," });
                _replacements.TryAdd(@"R", null);
                _replacements.TryAdd(@"S", new List<string> { @"5" });
                _replacements.TryAdd(@"T", null);
                _replacements.TryAdd(@"U", null);
                _replacements.TryAdd(@"V", new List<string> { @"\/" });
                _replacements.TryAdd(@"W", new List<string> { @"\/\/" });
                _replacements.TryAdd(@"X", null);
                _replacements.TryAdd(@"Y", null);
                _replacements.TryAdd(@"Z", null);

                return _replacements;
            }
        }
    }
}

