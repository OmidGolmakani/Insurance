using System.Collections.Generic;

namespace Domain.Helpers.ConstVariables
{
    public class HttpNames
    {
        public const string Add = "Post";
        public const string Update = "Put";
        public const string Delete = "Delete";
        public const string BachDelete = "BachDelete";
        public const string BatchUpdate = "BatchUpdate";
        public const string Get = "Get";
        public const string Gets = "Gets";
        public readonly static List<string> AcceptLanguageMethods = new List<string> { "Gets" };
    }
}
