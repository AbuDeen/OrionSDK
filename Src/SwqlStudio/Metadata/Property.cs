﻿
namespace SwqlStudio.Metadata
{
    class Property
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public bool IsNavigable { get; set; }
        public bool IsInherited { get; set; }
        public bool IsKey { get; set; }
    }
}
