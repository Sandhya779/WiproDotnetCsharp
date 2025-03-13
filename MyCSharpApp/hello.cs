class Test
{
    public void Incr(ref int x)
    {
        x++;
    }
    static void Main()
    {
        int x = 12;
        Test test=new Test();
        test.Incr(ref x);
        Console.WriteLine(x);
    }
}
