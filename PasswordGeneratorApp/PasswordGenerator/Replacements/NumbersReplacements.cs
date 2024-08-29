using System.Collections.Generic;

namespace PasswordGeneratorApp
{
    class NumbersReplacements : Replacement
    {
        public override Dictionary<string, List<string>> Replacements { 
            get
            {
                var _replacements = new Dictionary<string, List<string>>();

                _replacements.TryAdd(@"0", new List<string> { @"O", @"o" });
                _replacements.TryAdd(@"1", new List<string> { @"!", @"|", @"I", @"i" });
                _replacements.TryAdd(@"2", new List<string> { @"?", @"Z", @"z" });
                _replacements.TryAdd(@"3", new List<string> { @"3", @"M", @"m" });
                _replacements.TryAdd(@"4", new List<string> { @"h" });
                _replacements.TryAdd(@"5", new List<string> { @"S", "s" });
                _replacements.TryAdd(@"6", new List<string> { @"G" });
                _replacements.TryAdd(@"7", null);
                _replacements.TryAdd(@"8", new List<string> { @"&", @"g" });
                _replacements.TryAdd(@"9", null);

                return _replacements;
            } 
        }
    }
}