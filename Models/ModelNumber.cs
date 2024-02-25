namespace MyApp.Models
{
    public class ModelNumber
    {
        private readonly string productCode;
        private readonly string branch;
        private readonly string lot;

        private static T ValidateNotNull<T>(T value, string paramName)
        {
            if (value == null)
            {
                throw new ArgumentNullException(paramName);
            }

            return value;
        }

        public ModelNumber(string productCode, string branch, string lot)
        {
            this.productCode = ValidateNotNull(productCode, nameof(productCode));
            this.branch = ValidateNotNull(branch, nameof(branch));
            this.lot = ValidateNotNull(lot, nameof(lot));
        }

        public override string ToString()
        {
            return this.productCode + "-" + this.branch + "-" + this.lot;
        }
    }
}