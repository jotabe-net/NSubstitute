﻿namespace NSubstitute.Acceptance.Specs
{
    public interface ISomething
    {
        int Count();
        string Echo(int i);
        int Funky(float percentage, int amount, string label, ISomething something);
        int Add(int a, int b);
    }
}