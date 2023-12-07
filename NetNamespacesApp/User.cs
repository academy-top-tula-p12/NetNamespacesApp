using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetNamespacesApp;

internal class User
{
    public required string Name { get; set; }
    public required int Age { set; get; }
}

class Money
{
    decimal course;
    static int n;

    Money()
    {
        course = 0;
    }

    static Money()
    {
        n = 100;
    }

    static public int GetN()
    {
        return n;
    }

    public Money(decimal course)
    {
        this.course = course;
    }

    public decimal Course
    {
        get => course;
        set => course = value;
    }
}

static class MyMath
{
    static public int Sum(int a, int b)
    {
        return a + b;
    }

    static public double Sum(double a, double b)
    {
        return a + b;
    }

    static public int Sum(int a, int b, int c)
    {
        return a + b + c;
    }
}

readonly struct Account
{
    public readonly int id;
    public readonly string name;
}
