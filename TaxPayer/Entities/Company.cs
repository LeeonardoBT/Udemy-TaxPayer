namespace TaxPayer.Entities
{
    class Company : TaxPayer_
    {
        public int NumberOfEmployees { get; set; }

        public Company()
        {
        }

        public Company(string name, double anualIncome, int numberOfEmployees)
            : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double tax = NumberOfEmployees > 10 ? 0.14 : 0.16;

            return AnualIncome * tax;
        }
    }
}
