using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Millionaire
{
    public class Data
    {
        public string? Question { get; set; }
        public string[] Answer { get; set; } = new string[4];
        public int? RightIndex { get; set; }
    }
}
