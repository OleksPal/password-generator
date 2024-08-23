namespace PasswordGeneratorApp.Generator
{
    public interface IPasswordGeneratable
    {
        string Vocabulary { get; set; }

        string GenerateNonMemorablePassword(int passwordSize);
        string GenerateMemorablePassword(string userKeywords);
    }
}
