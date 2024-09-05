using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace testFirstWeekInData
{
    public class Threats
    {

        public string ThreatType { get; set; }
        public int Volume {  get; set; }

        public int Sophistication { get; set; }

        public string Target { get; set; }

        
        // O(1)
        public string GetJsonToString()
        {
            string threatsText = File.ReadAllText(@"..threats.json");
            var threat = JsonSerializer.Deserialize<Threats>(threatsText);
            return threatsText;
        }

        // O(1)
        public Threats(string threatType, int volume, int sophistication, string target) 
        { 
            ThreatType = threatType;
            Volume = volume;
            Sophistication = sophistication;
            Target = target;
        }
      
        // O(1)
        public int CalcRangeSeverity()
        {
            int TargetValue = CalcTheTargetValue(Target);
            int severity = (Volume * Sophistication) + TargetValue;

            return severity;
        }

 
        // O(1)
        public int CalcTheTargetValue(string Target)
        {
            int result;
            switch (Target)
                {
                case "Web Server":
                    result = 10; break;

                case "Database":
                    result =15; break;
                case "User Credentials":
                    result = 20; break;
                default:
                    result = 5; break;
                }
            return result;
        }



    }
}
