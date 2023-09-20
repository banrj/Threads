using System.Diagnostics;
int num = 21;
Thread.CurrentThread.Name = "main";
ConvertToBiNum(num);
Thread mythread = new Thread(ConvertToBiNum);
mythread.Name = "back";
mythread.Start(num);
void ConvertToBiNum(object num)
{
    Console.WriteLine();
    Console.WriteLine(Thread.CurrentThread.Name + " начал работу...");
    Stopwatch stpWatch = new Stopwatch();
    stpWatch.Start();
    if (num is int newNum)
    {

        string answer = "";
        Console.WriteLine($"До перевода {num}");
        while (newNum != 1)
        {
            answer = (newNum % 2).ToString() + answer;
            newNum /= 2;

        }
        answer = (newNum % 2).ToString() + answer;
        Console.WriteLine($"После {answer}");

    }
    
   
    stpWatch.Stop();
    Console.WriteLine("StopWatch: " + stpWatch.ElapsedTicks.ToString());
    Console.WriteLine(Thread.CurrentThread.Name + " закончил работу...");
}