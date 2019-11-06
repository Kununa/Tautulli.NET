using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Tautulli.Net.DataTypes
{
    public class Platform
    {

        private readonly string value;

        [JsonProperty("Chrome")]
        public static readonly Platform Chrome = new Platform("Chrome");
        [JsonProperty("Firefox")]
        public static readonly Platform Firefox = new Platform("Firefox");
        [JsonProperty("iOS")]
        public static readonly Platform IOs = new Platform("iOS");
        [JsonProperty("Playstation 4")]
        public static readonly Platform Playstation4 = new Platform("Playstation 4");

        private Platform(string value)
        {
            this.value = value;
        }

        public static implicit operator Platform(string s)
        {
            return new Platform(s);
        }

        public static bool operator ==(Platform a, Platform b) => a is null && b is null || !(a is null) && a.Equals(b);
        public static bool operator !=(Platform a, Platform b) => a is null && !(b is null) || !(a is null) && !a.Equals(b);

        public override string ToString()
        {
            return value;
        }

        protected bool Equals(Platform other)
        {
            return string.Equals(value, other.value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Platform)obj);
        }

        public override int GetHashCode()
        {
            return (value != null ? value.GetHashCode() : 0);
        }
    }
}
