namespace Tautulli.Net.DataTypes
{
    public class OrderDir
    {
        private readonly string value;

        public static readonly OrderDir Desc = new OrderDir("desc");
        public static readonly OrderDir Asc = new OrderDir("asc");

        private OrderDir(string value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return value;
        }
    }
}
