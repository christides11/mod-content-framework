using System;

namespace mcf.umod
{
    [AttributeUsage(AttributeTargets.Class)]
    public class UModContentParserAttribute : Attribute
    {
        public string parserPath;
        public string parserNickname;

        public UModContentParserAttribute(string parserPath, string nickname)
        {
            this.parserPath = parserPath;
            this.parserNickname = nickname;
        }
    }
}