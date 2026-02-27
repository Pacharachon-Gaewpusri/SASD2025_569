using SkiaSharp;
using System;
using System.Collections.Generic;

namespace SkiaLiteUI;

public abstract class Widget
{
    public virtual void Act(float deltaTime) { }
    public abstract void Draw(SKCanvas canvas);
}

public class RectWidget
{
    public Vector Position { get; }
    public Vector Size { get; }
    public SKColor Color { get; init; } = SKColors.White;
    public float Radius { get; set; } = 0;

    public RectWidget(Vector origin, Vector size)
    {
        Position = origin;
        Size = size;
    }

    //public void Act(float deltaTime)
    //{
    //}

    //public void Draw(SKCanvas canvas)
    //{
    //}

    public static explicit operator SKRect(RectWidget r)
    {
        return new SKRect(  r.Position.X, r.Position.Y, // todo: Symmetry Format
                            r.Position.X + r.Size.X,
                            r.Position.Y + r.Size.Y);
    }

    // todo: Where this method should move into ?
    public static RectWidget CreateRandom(Random rand, Vector max, Vector size)
    {
        var widget = new RectWidget(rand.NextVector(max), size)
        { Color = new SKColor((byte)rand.Next(256), (byte)rand.Next(256), (byte)rand.Next(256)) };
        // todo: Extract & Move Method: rand.NextColor()
        return widget;
    }
}
