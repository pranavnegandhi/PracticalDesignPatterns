using Newtonsoft.Json;
using System;

namespace Prototype
{
    [Serializable]
    public class Document : ICloneable<Document>
    {
        public Document()
        {
            CreatedOn = DateTime.UtcNow;
            Text = string.Empty;
        }

        public DateTime CreatedOn
        {
            get;
            private set;
        }

        public string Text
        {
            get;
            set;
        }

        public int Version
        {
            get;
            private set;
        }

        public Document Clone()
        {
            var self = JsonConvert.SerializeObject(this);
            var clone = JsonConvert.DeserializeObject<Document>(self);
            clone.CreatedOn = DateTime.UtcNow;
            clone.Version = Version + 1;

            return clone;
        }

        public override string ToString()
        {
            return $"Text: {Text}\r\nCreated on: {CreatedOn}, version: {Version}";
        }
    }
}