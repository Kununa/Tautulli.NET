using System;
using System.Collections.Generic;
using System.Text;

namespace Tautulli.Net.DataTypes
{
    public class StatsType
    {
        private readonly string value;

        public static readonly StatsType Plays = new StatsType("plays");
        public static readonly StatsType Duration = new StatsType("duration");

        private StatsType(string value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return value;
        }
    }
}
