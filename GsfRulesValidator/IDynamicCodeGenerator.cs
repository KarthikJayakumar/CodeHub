using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GsfRulesValidator
{
    public interface IDynamicCodeGenerator
    {
        string Run(string s);
    }
}
