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

                _replacemets.TryAdd(@"a", [@"@"]);
                _replacemets.TryAdd(@"b", [@"|o", @"!o"]);
                _replacemets.TryAdd(@"c", null);
                _replacemets.TryAdd(@"d", [@"o|", @"o!"]);
                _replacemets.TryAdd(@"e", null);
                _replacemets.TryAdd(@"f", null);
                _replacemets.TryAdd(@"g", [@"9"]);
                _replacemets.TryAdd(@"h", null);
                _replacemets.TryAdd(@"i", [@"!"]);
                _replacemets.TryAdd(@"j", null);
                _replacemets.TryAdd(@"k", [@"|<"]);
                _replacemets.TryAdd(@"l", [@"|", @"1"]);
                _replacemets.TryAdd(@"m", [@"3"]);
                _replacemets.TryAdd(@"n", null);
                _replacemets.TryAdd(@"o", [@"0"]);
                _replacemets.TryAdd(@"p", [@"|^", @"|*"]);
                _replacemets.TryAdd(@"q", null);
                _replacemets.TryAdd(@"r", null);
                _replacemets.TryAdd(@"s", [@"5"]);
                _replacemets.TryAdd(@"t", null);
                _replacemets.TryAdd(@"u", null);
                _replacemets.TryAdd(@"v", [@"\/"]);
                _replacemets.TryAdd(@"w", [@"\/\/", @"\/v", @"v\/"]);
                _replacemets.TryAdd(@"x", null);
                _replacemets.TryAdd(@"y", null);
                _replacemets.TryAdd(@"z", [@"2"]);

                return _replacemets;
            }
        }
    }
}