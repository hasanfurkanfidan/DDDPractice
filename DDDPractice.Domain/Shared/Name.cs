namespace DDDPractice.Domain.Shared
{
    public sealed record Name
    {
        public string Value { get; init; }
        public Name(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name cannot be empty.", nameof(value));
            }

            if (value.Length < 3)
            {
                throw new ArgumentException("Name can not ve smaller than 3 characters");
            }

            Value = value;
        }
    }
}
