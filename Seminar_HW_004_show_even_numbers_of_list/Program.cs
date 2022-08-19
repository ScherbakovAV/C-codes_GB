Console.Write("Enter a number...");
int EndNumber = Convert.ToInt32(Console.ReadLine());
int StartNumber = 1;
while (StartNumber <= EndNumber)
{
    if (StartNumber % 2 == 0)
    {
        Console.Write(StartNumber + " ");
        // Console.Write ($"{StartNumber}, ");
    }
    ++StartNumber;
}