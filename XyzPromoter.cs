using System;

public class XyzPromoter : Promoter, IBodyBuilder, IVlogger
{
    public XyzPromoter(string firstName, string lastName, string cellPhone) : base(firstName, lastName, cellPhone)
    {
    }

    protected override void ShareWithInnerCircle()
    {
        Console.WriteLine("I share with my Instagram followers.");
    }

    protected override void UsePaidAds()
    {
        Console.WriteLine("I use Facebook Ads.");
    }

    public void Vlog()
    {
        Console.WriteLine("I use a DSLR in order to vlog.");
    }

    public void Workout()
    {
        Console.WriteLine("I workout at my house.");
    }
}