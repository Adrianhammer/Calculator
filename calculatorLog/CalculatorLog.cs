using Newtonsoft.Json;
namespace calculatorLog
{
    public class Operation
    {
        public double Operand1 { get; set; }
        public double Operand2 { get; set; }
        public string OperationType { get; set; }
        public double Result { get; set; }
    }

    public class Root
    {
        public List<Operation> Operations { get; set; }
    }

    public class CalculatorLog
    {
        static string jsonFilePath = @"C:/study/code/Calculator/Calculator/bin/Debug/net8.0/calculatorlog.json";

        public static void viewLog()
        {
            try
            {
                //Read the JSON content from the file
                string jsonContent = File.ReadAllText(jsonFilePath);

                //Deserialize the JSON content to a root object
                Root root = JsonConvert.DeserializeObject<Root>(jsonContent);

                //Print the operation to the terminal
                foreach (var operation in root.Operations)
                {
                    Console.WriteLine($"Operand1: {operation.Operand1}");
                    Console.WriteLine($"Operand2: {operation.Operand2}");
                    Console.WriteLine($"Operation: {operation.OperationType}");
                    Console.WriteLine($"Result: {operation.Result}");
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured while reading the log file: " + ex.Message);
            }
        }
    }
}
