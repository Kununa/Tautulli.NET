using Newtonsoft.Json;

namespace Tautulli.Net.DataTypes
{
    public class MediaType
    {

        private readonly string value;

        [JsonProperty("movie")]
        public static readonly MediaType Movie = new MediaType("movie");
        [JsonProperty("episode")]
        public static readonly MediaType Episode = new MediaType("episode");
        [JsonProperty("track")]
        public static readonly MediaType Track = new MediaType("track");

        private MediaType(string value)
        {
            this.value = value;
        }

        public static implicit operator MediaType(string s)
        {
            return new MediaType(s);
        }

        public static bool operator ==(MediaType a, MediaType b) => a is null && b is null || !(a is null) && a.Equals(b);
        public static bool operator !=(MediaType a, MediaType b) => a is null && !(b is null) || !(a is null) && !a.Equals(b);

        public override string ToString()
        {
            return value;
        }

        protected bool Equals(MediaType other)
        {
            return string.Equals(value, other.value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((MediaType)obj);
        }

        public override int GetHashCode()
        {
            return (value != null ? value.GetHashCode() : 0);
        }
    }
}
