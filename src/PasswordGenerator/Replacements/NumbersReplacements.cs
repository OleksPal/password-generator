using System.Collections.Generic;

namespace PasswordGeneratorApp
{
    class NumbersReplacements : Replacement
    {
        public override Dictionary<string, List<string>> Replacements { 
            get
            {
                var _replacements = new Dictionary<string, List<string>>();

                _replacements.TryAdd(@"0", [@"O", @"o"]);
                _replacements.TryAdd(@"1", [@"!", @"|", @"I", @"i"]);
                _replacements.TryAdd(@"2", [@"?", @"Z", @"z"]);
                _replacements.TryAdd(@"3", [@"3", @"M", @"m"]);
                _replacements.TryAdd(@"4", [@"h"]);
                _replacements.TryAdd(@"5", [@"S", "s"]);
                _replacements.TryAdd(@"6", [@"G"]);
                _replacements.TryAdd(@"7", null);
                _replacements.TryAdd(@"8", [@"&"]);
                _replacements.TryAdd(@"9", [@"g"]);

                return _replacements;
            } 
        }
    }
}