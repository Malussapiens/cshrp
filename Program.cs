string str = "---БЕГУЩАЯ СТРОКА---";
string blank = " ";
Console.CursorVisible = false;
int i = 0;
while (i < 3)
{
    int begin = 0 - str.Length, end = 0;
    Console.Clear();
    int strlen = str.Length;
    while (begin < Console.BufferWidth)
    {
        if (begin <= 0)
        {
            Console.CursorLeft = 0;
            Console.Write(str.Substring(str.Length - end));
        }

        if (begin > 0 && end <= Console.BufferWidth)
        {
            Console.CursorLeft = begin;
            Console.Write(str);
            Console.CursorLeft = begin - 1;
            Console.Write(" ");
        }

        if (end > Console.BufferWidth)
        {
            strlen--;
            Console.CursorLeft = begin;
            Console.Write(str.Substring(0, strlen));
            Console.CursorLeft = begin - 1;
            Console.Write(" ");
        }

        end++; begin++;
        Thread.Sleep(100);
    }
        Console.Write("  ");
    i++;
}
Console.CursorVisible = true;
