using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GsfRulesValidator
{
    public class DynamicCodeGenerator : IDynamicCodeGenerator
    {
        private string _methodImplementaion = string.Empty;
        public DynamicCodeGenerator(string methodImplementaion)
        {
            _methodImplementaion = methodImplementaion;
        }
        public string Run(string s)
        {
            return string.Empty;
        }
    }
}
