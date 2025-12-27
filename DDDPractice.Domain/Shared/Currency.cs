namespace DDDPractice.Domain.Shared
{
    public sealed record Currency
    {
        internal static readonly Currency None = new("");
        public static readonly Currency USD = new Currency("USD");
        public static readonly Currency EUR = new Currency("EUR");
        public static readonly Currency TRY = new Currency("TRY");

        public string Code { get; init; }

        private Currency(string code)
        {
            Code = code;
        }

        public static Currency FromCode(string code)
        {
            return AllCurrencies.FirstOrDefault(c => c.Code == code)
                ?? throw new ArgumentException($"Unsupported currency code: {code}");
        }

        public static readonly IReadOnlyCollection<Currency> AllCurrencies = new List<Currency>
        {
            USD,
            EUR,
            TRY
        };
    }
}
