// See https://aka.ms/new-console-template for more information;
int n = int.Parse(Console.ReadLine());
int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
for (int i = 0; i < n; i++)
{
    if (arr[i] > 0)
    {
        arr[i] = 1;
    }
    else if (arr[i] < 0)
    {
        arr[i] = 2;
    }
    else if(arr[i] == 0) 
    {
        arr[i] = 0;
    }

}
foreach (int x in arr)
{
    Console.Write(x);
    Console.Write(' ');
}
Console.ReadLine();

