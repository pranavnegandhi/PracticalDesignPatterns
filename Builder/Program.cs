using System;

namespace Builder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EmailBuilder emailBuilder = new EmailBuilder();
            var email = emailBuilder.Reset()
                .From("john@example.com")
                .To("jane@example.com")
                .To("jim@example.com")
                .WithSubject("101 Ways to Refactor")
                .WithBody("Lorem ipsu…")
                .GetResults();

            Console.WriteLine(emailBuilder.ToString());

            JsonBuilder jsonBuilder = new JsonBuilder();
            var json = jsonBuilder.Reset()
                .From("john@example.com")
                .To("jane@example.com")
                .To("jim@example.com")
                .WithSubject("101 Ways to Refactor")
                .WithBody("Lorem ipsu…")
                .GetResults();

            Console.WriteLine(json);
        }
    }
}