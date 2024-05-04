using fibonaccipilha;

int inputInteger(string message, int? min = null, int? max = null)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine());

    while (true)
    {
        bool correctValue = (min != null ? value >= min : true) && (max != null ? value <= max : true);

        if (correctValue)
            break;

        string invalid = min != null ? $"Valor precisa ser maior ou igual a {min}" : "";
        invalid += invalid == "" ? "Valor precisa ser " : max != null ? " e " : "";
        invalid += max != null ? $"menor ou igual a {max}" : "";
        invalid += ": ";

        Console.Write(invalid);
        value = int.Parse(Console.ReadLine());
    }

    return value;
}

int[] fibonacci(int length)
{
    int[] sequence = new int[length];

    int last = 1;
    int current = 0;

    for (int i = 0; i < length; i++)
    {
        sequence[i] = current;

        current += last;
        last = current - last;
    }

    return sequence;
}

Stack stack = new Stack();

int sequenceLength = inputInteger("Informe até onde deseja calcular a sequência fibonacci: ", min: 1);

int[] sequence = fibonacci(sequenceLength);

for (int i = 0; i < sequenceLength; i++)
    stack.Push(sequence[i]);

Console.WriteLine("Sequência na pilha: ");

stack.Display();