using System;

namespace mcf.addressables
{
    [AttributeUsage(AttributeTargets.Class)]
    public class AddressablesContentParserAttribute : Attribute
    {
        public string parserPath;
        public string parserNickname;

        public AddressablesContentParserAttribute(string parserPath, string nickname)
        {
            this.parserPath = parserPath;
            this.parserNickname = nickname;
        }
    }
}