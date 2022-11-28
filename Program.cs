

int mim = 0;
int voce = 0;
int alimentos;
Console.Write("Vai dividir quantos alimentos?");
alimentos = Convert.ToInt32(Console.ReadLine());


while (alimentos >= voce);
{
    Console.WriteLine($"{voce} para você. {mim} para mim.");
    voce += 1;
    mim += 1;
}
