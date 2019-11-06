namespace Tautulli.Net.DataTypes
{
    public class TranscodeDecision
    {
        private readonly string value;

        public static readonly TranscodeDecision DirectPlay = new TranscodeDecision("direct play");
        public static readonly TranscodeDecision Copy = new TranscodeDecision("copy");
        public static readonly TranscodeDecision Transcode = new TranscodeDecision("transcode");

        private TranscodeDecision(string value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return value;
        }
    }
}
