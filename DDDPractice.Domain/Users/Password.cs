namespace DDDPractice.Domain.Users
{
    public sealed record Password
    {
        public string Value { get; init; }
        public Password(string value)
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < 8)
            {
                throw new ArgumentException("Password must be at least 8 characters long.", nameof(value));
            }

            Value = value;
        }
    }
}
