namespace Builder
{
    public interface IMessageBuilder<T>
    {
        IMessageBuilder<T> To(string recipient);

        IMessageBuilder<T> From(string sender);

        T GetResults();

        IMessageBuilder<T> Reset();

        IMessageBuilder<T> WithBody(string body);

        IMessageBuilder<T> WithSubject(string subject);
    }
}