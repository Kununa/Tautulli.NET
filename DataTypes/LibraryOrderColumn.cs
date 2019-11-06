using System;
using System.Collections.Generic;
using System.Text;

namespace Tautulli.Net.DataTypes
{
    public class LibraryOrderColumn
    {
        private readonly string value;

        public static readonly LibraryOrderColumn LibraryThumb = new LibraryOrderColumn("library_thumb");
        public static readonly LibraryOrderColumn SectionName = new LibraryOrderColumn("section_name");
        public static readonly LibraryOrderColumn SectionType = new LibraryOrderColumn("section_type");
        public static readonly LibraryOrderColumn Count = new LibraryOrderColumn("count");
        public static readonly LibraryOrderColumn ParentCount = new LibraryOrderColumn("parent_count");
        public static readonly LibraryOrderColumn ChildCount = new LibraryOrderColumn("child_count");
        public static readonly LibraryOrderColumn LastAccessed = new LibraryOrderColumn("last_accessed");
        public static readonly LibraryOrderColumn LastPlayed = new LibraryOrderColumn("last_played");
        public static readonly LibraryOrderColumn Plays = new LibraryOrderColumn("plays");
        public static readonly LibraryOrderColumn Duration = new LibraryOrderColumn("duration");

        private LibraryOrderColumn(string value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return value;
        }
    }
}
