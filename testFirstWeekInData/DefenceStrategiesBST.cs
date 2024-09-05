using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace testFirstWeekInData
{
    public class DefenceStrategiesBST
    {
        private TreeNode root;
        public int MinSeverity { get; set; }
        public int MaxSeverity { get; set; }
        public List<string> Defenses { get; set; }


        // O(1)
        public string GetJsonToString()
        {
            string Text = File.ReadAllText(@"..defenceStrategiesBalanced.json");
            DefenceStrategiesBST Defnce = JsonSerializer.Deserialize<DefenceStrategiesBST>(Text);
            return Text;
        }


        public void InsertDefence(int minSeverity, int maxSeverity, List<string> defences)
        {
            root = InsertDefenceRec(root, minSeverity, maxSeverity);
        }

        public DefenceStrategiesBST InsertDefenceRec(TreeNode node, int minSeverity, int maxSeverity, List<string> defences)
        {
            return new DefenceStrategiesBST();
        }




    }
}
