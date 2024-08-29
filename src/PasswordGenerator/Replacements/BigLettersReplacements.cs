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

                _replacements.TryAdd(@"A", [@"/-\", @"/=\", @"/~\", @"/-|", @"/=|", @"/~|", @"|-\", @"|=\", @"|~\"]);
                _replacements.TryAdd(@"B", [@"|3", @"!3"]);
                _replacements.TryAdd(@"C", null);
                _replacements.TryAdd(@"D", [@"|)", @"|]", @"|}", @"!)", @"!]", @"!}"]);
                _replacements.TryAdd(@"E", null);
                _replacements.TryAdd(@"F", null);
                _replacements.TryAdd(@"G", [@"6"]);
                _replacements.TryAdd(@"H", [@"|-|", @"|=|", @"!-!", @"!=!", @"!-|", @"|=!"]);
                _replacements.TryAdd(@"I", [@"1", @"|"]);
                _replacements.TryAdd(@"J", [@"_|", @"_]", @"_)", @"]", @"_}"]);
                _replacements.TryAdd(@"K", [@"|<"]);
                _replacements.TryAdd(@"L", [@"|_", @"(_", @"[_", @"{_"]);
                _replacements.TryAdd(@"M", [@"|\/|", @"[\/]", @"{\/}", @"(\/)", @"(\/|", @"|\/)"]);
                _replacements.TryAdd(@"N", [@"|\|", @"!\|", @"|\!", @"!\!"]);
                _replacements.TryAdd(@"O", [@"0"]);
                _replacements.TryAdd(@"P", [@"|^", @"|*"]);
                _replacements.TryAdd(@"Q", [@"O,", @"0,"]);
                _replacements.TryAdd(@"R", null);
                _replacements.TryAdd(@"S", [@"5"]);
                _replacements.TryAdd(@"T", null);
                _replacements.TryAdd(@"U", null);
                _replacements.TryAdd(@"V", [@"\/"]);
                _replacements.TryAdd(@"W", [@"\/\/", @"\/v", @"v\/"]);
                _replacements.TryAdd(@"X", null);
                _replacements.TryAdd(@"Y", null);
                _replacements.TryAdd(@"Z", [@"2"]);

                return _replacements;
            }
        }
    }
}

