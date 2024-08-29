using System.Collections.Generic;

namespace PasswordGeneratorApp
{
    public abstract class Replacement
    {
        public abstract Dictionary<string, List<string>> Replacements { get; }
    }
}
