namespace TaxPayer.Entities
{
    class Individual : TaxPayer_
    {
        public double HealthExpenditures { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double anualIncome, double healthExpenditures)
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double tax = AnualIncome < 20000.00 ? 0.15 : 0.25;
            
            return (AnualIncome * tax) - (HealthExpenditures * 0.5);
        }
    }
}
