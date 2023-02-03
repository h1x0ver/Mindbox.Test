﻿namespace Mindbox.Task.Interfaces;

public interface ITriangle : IFigure
{
    double EdgeA { get; }
    double EdgeB { get; }
    double EdgeC { get; }

    bool IsRightTriangle { get; }
}
