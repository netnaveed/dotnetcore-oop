using System;

public class BlogWriter : Writer
{
    public BlogWriter(string firstName, string lastName) : base(firstName, lastName)
    {
    }

    public override void Vlog()
    {
        Console.WriteLine("I vlog using GoPro.");
    }

    public override void Write()
    {
        Console.WriteLine("I write for own blog.");
    }
}