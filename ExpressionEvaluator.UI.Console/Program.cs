using ExpressionEvaluator.Core;

while (true)
{
    Console.Write("Ingrese la operación a evaluar ");
    var input = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(input))
        break;

    try
    {
        var result = Evaluator.Evaluate(input);
        Console.WriteLine($"Result: {result}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}