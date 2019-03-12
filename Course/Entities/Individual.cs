namespace Course.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double tax = 0;

            if (AnualIncome <= 20000.00)
            {
                tax = AnualIncome * 0.15;
            }
            else
            {
                tax = AnualIncome * 0.25;
            }

            if (HealthExpenditures > 0)
            {
                double healthExpenditures = HealthExpenditures * 0.5;
                tax -= healthExpenditures;
            }

            return tax;
        }
    }
}
