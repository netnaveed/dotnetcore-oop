using System;

public class AbcPromoter : Promoter
{
    public AbcPromoter(string firstName, string lastName, string cellPhone) : base(firstName, lastName, cellPhone)
    {
    }

    protected override void ShareWithInnerCircle()
    {
        Console.WriteLine("I share with my friends.");
    }

    protected override void UsePaidAds()
    {
        Console.WriteLine("I use Google AdWords.");
    }
}