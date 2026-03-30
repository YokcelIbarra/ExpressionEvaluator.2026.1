using System.Globalization;

namespace ExpressionEvaluator.Core;

public class Evaluator
{
    public static double Evaluate(string infix)
    {
        var tokens = Tokenize(infix);
        var postfix = InfixToPostfix(tokens);
        return EvaluatePostfix(postfix);
    }

    private static Queue<string> Tokenize(string infix)
    {
        var tokens = new Queue<string>();
        var number = string.Empty;

        foreach (char c in infix.Replace(" ", ""))
        {
            if (char.IsDigit(c) || c == '.')
            {
                number += c;
            }
            else if (IsOperator(c))
            {
                if (!string.IsNullOrEmpty(number))
                {
                    tokens.Enqueue(number);
                    number = string.Empty;
                }

                tokens.Enqueue(c.ToString());
            }
            else
            {
                throw new Exception("Syntax error.");
            }
        }

        if (!string.IsNullOrEmpty(number))
        {
            tokens.Enqueue(number);
        }

        return tokens;
    }

    private static Queue<string> InfixToPostfix(Queue<string> infixTokens)
    {
        var output = new Queue<string>();
        var operators = new Stack<string>();

        while (infixTokens.Count > 0)
        {
            var token = infixTokens.Dequeue();

            if (double.TryParse(token, NumberStyles.Any, CultureInfo.InvariantCulture, out _))
            {
                output.Enqueue(token);
            }
            else if (token == "(")
            {
                operators.Push(token);
            }
            else if (token == ")")
            {
                while (operators.Count > 0 && operators.Peek() != "(")
                {
                    output.Enqueue(operators.Pop());
                }

                if (operators.Count == 0)
                {
                    throw new Exception("Syntax error.");
                }

                operators.Pop();
            }
            else if (IsOperator(token))
            {
                while (operators.Count > 0 &&
                       operators.Peek() != "(" &&
                       (
                           Precedence(operators.Peek()) > Precedence(token) ||
                           (Precedence(operators.Peek()) == Precedence(token) && token != "^")
                       ))
                {
                    output.Enqueue(operators.Pop());
                }

                operators.Push(token);
            }
        }

        while (operators.Count > 0)
        {
            if (operators.Peek() == "(")
            {
                throw new Exception("Syntax error.");
            }

            output.Enqueue(operators.Pop());
        }

        return output;
    }

    private static double EvaluatePostfix(Queue<string> postfix)
    {
        var values = new Stack<double>();

        while (postfix.Count > 0)
        {
            var token = postfix.Dequeue();

            if (double.TryParse(token, NumberStyles.Any, CultureInfo.InvariantCulture, out double number))
            {
                values.Push(number);
            }
            else if (IsOperator(token))
            {
                if (values.Count < 2)
                {
                    throw new Exception("Syntax error.");
                }

                double b = values.Pop();
                double a = values.Pop();

                values.Push(token switch
                {
                    "+" => a + b,
                    "-" => a - b,
                    "*" => a * b,
                    "/" => a / b,
                    "^" => Math.Pow(a, b),
                    _ => throw new Exception("Syntax error.")
                });
            }
        }

        if (values.Count != 1)
        {
            throw new Exception("Syntax error.");
        }

        return values.Pop();
    }

    private static int Precedence(string op) => op switch
    {
        "^" => 3,
        "*" => 2,
        "/" => 2,
        "+" => 1,
        "-" => 1,
        _ => 0
    };

    private static bool IsOperator(char c) => "+-*/^()".Contains(c);

    private static bool IsOperator(string token) => token is "+" or "-" or "*" or "/" or "^";
}