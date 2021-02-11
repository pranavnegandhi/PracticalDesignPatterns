using System;
using System.Linq;
using System.Net.Mail;

namespace Builder
{
    public class EmailBuilder : IMessageBuilder<MailMessage>
    {
        private MailMessage _message;

        public IMessageBuilder<MailMessage> Reset()
        {
            _message = new MailMessage();

            return this;
        }

        public IMessageBuilder<MailMessage> To(string recipient)
        {
            _message.To.Add(recipient);

            return this;
        }

        public IMessageBuilder<MailMessage> From(string sender)
        {
            _message.From = new MailAddress(sender);

            return this;
        }

        public IMessageBuilder<MailMessage> WithBody(string body)
        {
            _message.Body = body;

            return this;
        }

        public IMessageBuilder<MailMessage> WithSubject(string subject)
        {
            _message.Subject = subject;

            return this;
        }

        public MailMessage GetResults()
        {
            return _message;
        }

        public override string ToString()
        {
            return $"From: {_message.From.Address}\r\n" +
                $"To: {String.Join(',', _message.To.Select(recipient => recipient.Address).ToArray())}\r\n" +
                $"Subject: {_message.Subject}\r\n" +
                $"Containing: {_message.Body}\r\n";
        }
    }
}