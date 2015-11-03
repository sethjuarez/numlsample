using numl.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace numlsample.GettingStarted.Data
{
    public enum Outlook
    {
        Sunny,
        Overcast,
        Rainy
    }

    public enum Temperature
    {
        Low,
        High
    }

    public class Tennis
    {
        [Feature]
        public Outlook Outlook { get; set; }
        [Feature]
        public Temperature Temperature { get; set; }
        [Feature]
        public bool Windy { get; set; }
        [Label]
        public bool Play { get; set; }

        public override string ToString()
        {
            return $"Tennis - Outlook: {Outlook}, Temp: {Temperature}, Windy: {Windy}";
        }
    }
}
