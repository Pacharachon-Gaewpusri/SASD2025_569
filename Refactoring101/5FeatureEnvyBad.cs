using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring101.FeatureEnvyBad;

// 5
public class FeatureEnvyGood
{
    public void TestAdd()
    {
        var point = new Point(2, 3).Add(new Point(4, 5));
    }
}

public class Point
{
    public double X { get; }
    public double Y { get; }
    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }
    public Point Add(Point b)
    {
        return new Point(this.X + b.X, this.Y + b.Y);
    }
}
