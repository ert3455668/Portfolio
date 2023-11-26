// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("請輸入一個數字");
string Input = Console.ReadLine();
int Num = int.Parse(Input);
int Value = Num % 2;
//如果是雙數Value = 0，如果是單數Value = 1


    if(Num <= 1)
    {
        Console.WriteLine("請輸入大於1的數字");
    }
    else
    {
        switch (Value)
        {
            case 0:

            case 1:
                Console.WriteLine("您輸入的數字是雙數");
                break;

            case 2:
               Console.WriteLine("您輸入的數字是單數");
               break;
        }
    }
    Console.ReadLine();

