ExibirMensagem();
Somar(5, 6);
EhPar(12);
CalcularMedia(10, 8.5);

void ExibirMensagem()
{
    Console.WriteLine("Função Mensagem");
}

int Somar(int a, int b)
{
    Console.WriteLine(a+b);
    return a + b;
}

bool EhPar(int num)
{
    if(num%2==0)
    {
        Console.WriteLine(true);
        return true;
    } else
    {
        Console.WriteLine(false);
        return false;
    }
}

double CalcularMedia(double n1, double n2)
{
    Console.WriteLine((n1+n2)/2);
    return (n1 + n2) / 2;
}