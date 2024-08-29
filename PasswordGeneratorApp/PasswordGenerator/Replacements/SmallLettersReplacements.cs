using System.Collections.Generic;

namespace PasswordGeneratorApp
{
    class SmallLettersReplacements : Replacement
    {
        public override Dictionary<string, List<string>> Replacements
        {
            get
            {
                var _replacemets = new Dictionary<string, List<string>>();

                _replacemets.TryAdd(@"a", null);
                _replacemets.TryAdd(@"b", new List<string> { @"|o", @"!o" });
                _replacemets.TryAdd(@"c", null);
                _replacemets.TryAdd(@"d", new List<string> { @"o|", @"o!" });
                _replacemets.TryAdd(@"e", null);
                _replacemets.TryAdd(@"f", null);
                _replacemets.TryAdd(@"g", new List<string> { @"8" });
                _replacemets.TryAdd(@"h", null);
                _replacemets.TryAdd(@"i", null);
                _replacemets.TryAdd(@"j", null);
                _replacemets.TryAdd(@"k", new List<string> { @"|<" });
                _replacemets.TryAdd(@"l", new List<string> { @"|", @"1" });
                _replacemets.TryAdd(@"m", null);
                _replacemets.TryAdd(@"n", null);
                _replacemets.TryAdd(@"o", new List<string> { @"0" });
                _replacemets.TryAdd(@"p", new List<string> { @"|^", @"|*" });
                _replacemets.TryAdd(@"q", new List<string> { @"9" });
                _replacemets.TryAdd(@"r", null);
                _replacemets.TryAdd(@"s", new List<string> { @"5" });
                _replacemets.TryAdd(@"t", null);
                _replacemets.TryAdd(@"u", null);
                _replacemets.TryAdd(@"v", new List<string> { @"\/" });
                _replacemets.TryAdd(@"w", new List<string> { @"\/\/" });
                _replacemets.TryAdd(@"x", null);
                _replacemets.TryAdd(@"y", null);
                _replacemets.TryAdd(@"z", null);

                return _replacemets;
            }
        }
    }
}