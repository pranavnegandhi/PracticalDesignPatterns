using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace Builder
{
    public class JsonBuilder : IMessageBuilder<string>
    {
        private StringBuilder _builder;

        private JsonTextWriter _writer;

        public IMessageBuilder<string> Reset()
        {
            _builder = new StringBuilder();
            var sw = new StringWriter(_builder);
            _writer = new JsonTextWriter(sw);
            _writer.WriteStartObject();

            return this;
        }

        public IMessageBuilder<string> To(string recipient)
        {
            _writer.WritePropertyName("To");
            _writer.WriteValue(recipient);

            return this;
        }

        public IMessageBuilder<string> From(string sender)
        {
            _writer.WritePropertyName("From");
            _writer.WriteValue(sender);

            return this;
        }

        public IMessageBuilder<string> WithBody(string body)
        {
            _writer.WritePropertyName("Body");
            _writer.WriteValue(body);

            return this;
        }

        public IMessageBuilder<string> WithSubject(string subject)
        {
            _writer.WritePropertyName("Subject");
            _writer.WriteValue(subject);

            return this;
        }

        public string GetResults()
        {
            _writer.WriteEndObject();

            return _builder.ToString();
        }
    }
}