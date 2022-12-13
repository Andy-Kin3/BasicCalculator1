namespace BasicCalculator1
{
    public static class ExtensionMethods
    {
        public static bool HasDecimalPoint(this double? d)
        {
            if(d.HasValue == false)
            {
                return false;
            }

            return d % 1 > 0;
        }
    }
}
