Console.WriteLine("|    x   |   y    |");
for (double x = -0.5; x <= 3; x += 0.2)
{
    double y;
    if (x < 0) y = Math.Exp(x);
    else if (x >= 0 && x <= 4.5) y = 1-Math.Log(Math.Abs(1+x*x));
    else y = 2*x;
    Console.WriteLine($"|{x,8:F2}|{y,8:F2}|");
}

