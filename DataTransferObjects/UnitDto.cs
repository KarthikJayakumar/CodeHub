using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataTransferObjects
{
    public class UnitDto
    {
        public string UnitName { get; set; }
        public string FamilyName { get; set; }
        public string SerialNumber { get; set; }
        public string ParentSerialNumber { get; set; }
    }
}
