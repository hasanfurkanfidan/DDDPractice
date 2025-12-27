namespace DDDPractice.Domain.Users
{
    public sealed record Email
    {
        public string Value { get; init; }
        public Email(string value)
        {
            if (string.IsNullOrWhiteSpace(value) || !value.Contains("@"))
            {
                throw new ArgumentException("Invalid email format.", nameof(value));
            }


            Value = value;
        }
    }
}
