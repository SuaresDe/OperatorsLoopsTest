// See https://aka.ms/new-console-template for more information

OperatorExamples();

void OperatorExamples()
{
    int width = 3;

    width++;

    int height = 2 + 4;
    int area = width * height;
    Console.WriteLine(area);

    while (area > 50) 
    {
        height++;
        area = width * height;
    }

    do
    {
        width--;
        area = width * height;
    } while (area > 20);

    string result = "The area";
    result = result + " is " + area;
    Console.WriteLine(result);

    bool truthValue = true;
    Console.WriteLine(truthValue);
}

void looptest1() 
{
    int j = 2;
    for (int i = 1; i < 100; i = i * 2) {
        j = j - 1;
        while (j < 25)
        {
            j = j + 5;
            Console.WriteLine(j);
        }
    }
}   

void looptest2() 
{
    int p = 2;
    for (int q = 2; q < 32; q = q * 2) 
    {
        while (p < q) 
        {
            p = p * 2;
            Console.WriteLine("p = " + p);
        }
        q = p - q;
        Console.WriteLine("q = " + q);
    }
}

void looptest3() 
{
 while (true) { int i = 1;}
    
}