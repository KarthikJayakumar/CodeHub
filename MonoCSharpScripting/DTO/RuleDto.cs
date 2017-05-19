using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RuleDto
    {
        public int RuleId { get; set; }
        public string RuleName { get; set; }
        public string RuleType { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
       
        private string _parameterName = "targetValue";
        public string Code { get; set; }
        public string ParameterType { get; set; }
        public string ReturnType { get; set; }

        public string ParameterName { get; set; }
        public string Results { get; set; }
    }
}
