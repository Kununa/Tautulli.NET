namespace Tautulli.Net.DataTypes
{
    public class HistoryOrderColumn
    {
        private readonly string value;

        public static readonly HistoryOrderColumn Date = new HistoryOrderColumn("date");
        public static readonly HistoryOrderColumn FriendlyName = new HistoryOrderColumn("friendly_name");
        public static readonly HistoryOrderColumn IpAddress = new HistoryOrderColumn("ip_address");
        public static readonly HistoryOrderColumn Platform = new HistoryOrderColumn("platform");
        public static readonly HistoryOrderColumn Player = new HistoryOrderColumn("player");
        public static readonly HistoryOrderColumn FullTitle = new HistoryOrderColumn("full_title");
        public static readonly HistoryOrderColumn Started = new HistoryOrderColumn("started");
        public static readonly HistoryOrderColumn PausedCounter = new HistoryOrderColumn("paused_counter");
        public static readonly HistoryOrderColumn Stopped = new HistoryOrderColumn("stopped");
        public static readonly HistoryOrderColumn Duration = new HistoryOrderColumn("duration");

        private HistoryOrderColumn(string value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return value;
        }
    }
}
