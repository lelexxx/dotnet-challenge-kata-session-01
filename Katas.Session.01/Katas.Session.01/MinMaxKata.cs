﻿using System;
using System.Linq;

namespace Katas.Session._01;

public static class MinMaxKata
{
    /// <summary>
    /// This method return the min and max value from the given input string. All numbers in the given string are separated by a space
    /// Examples Input: "1 2 3 4 5"   =>  Output: "5 1"
    /// Output string must be two numbers separated by a single space, and highest number is first.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static string ComputeMinMax(string input)
    {
        int[] strings = input.Split(' ').Select(i => Convert.ToInt32(i)).ToArray();

        return $"{strings.Max()} {strings.Min()}";
    }
}
