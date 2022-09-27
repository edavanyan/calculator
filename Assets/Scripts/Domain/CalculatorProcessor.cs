
namespace Domain
{
    public class CalculatorProcessor : IProcessor
    {
        public string ProcessData(string inputText)
        {
            var splitResults = inputText.Split("+");
            if (splitResults.Length > 1)
            {
                var sum = 0;
                foreach (var number in splitResults)
                {
                    if (int.TryParse(number, out var parsedNumber))
                    {
                        sum += parsedNumber;
                    }
                    else
                    {
                        return "Error";
                    }
                }
                return sum.ToString();
            }

            return "Error";
        }
    }
}
