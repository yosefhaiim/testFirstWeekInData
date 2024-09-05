using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testFirstWeekInData
{
    public class TreeNode
    {
        public int MaxSeverity { get; set; }

        public int MinSeverity { get; set; }

        public List<string> Defences { get; set; }

        public TreeNode left { get; set; }

        public TreeNode right { get; set; }
        public TreeNode(int maxSeverity, int minSeverity, List<string> defences)
        {
            MaxSeverity = maxSeverity;
            MinSeverity = MinSeverity;
            Defences = defences;
            left = null;
            right = null;
        }
    }
}
