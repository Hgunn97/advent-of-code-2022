using System.IO;

namespace CommonServices
{
    public class GetInputService : IGetInputService
    {
        private const string BasePath = "Inputs";
        
        private string GetInput(string name)
        {
            return File.ReadAllText($"{BasePath}/{name}");
        }
    }
}