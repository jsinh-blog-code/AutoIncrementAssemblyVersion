#region Copyright Jsinh.in
//-----------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Jsinh.in">
//     Copyright (c) 2013 Jsinh.in. All rights reserved.
// </copyright>
// <summary>
//      Sample program to demonstrate Auto increment of version number for assembly in .NET.
// </summary>
//-----------------------------------------------------------------------------------------------------------------------------------------------------
#endregion

namespace AutoIncrementVersionNumber
{
    #region Namespace

    using System;

    #endregion

    /// <summary>
    /// Sample program to demonstrate Auto increment of version number for assembly in .NET.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main method.
        /// </summary>
        /// <param name="args">Input arguments.</param>
        public static void Main(string[] args)
        {
            //// Gets number of days since 1 day of Year 2000.
            const string TwoThousandYearDate = "01-01-2000";
            var startDate = DateTime.Parse(TwoThousandYearDate);
            var currentDate = DateTime.Now;
            var elapsedTimeSpan = currentDate.Subtract(startDate);

            var numberOfDaysSinceYearTwoThousand = elapsedTimeSpan.TotalDays;

            //// Gets number of seconds since mid-night.
            var timeSpanSinceMidnight = DateTime.Now - DateTime.Today;
            var totalNumberOfSecondsSinceMidnight = timeSpanSinceMidnight.TotalSeconds;

            var totalNumberOfSecondsSinceMidnightDivideByTwo = totalNumberOfSecondsSinceMidnight / 2;

            //// Gets current version number of the executing assembly.
            var currentExecutingAssemblyVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            Console.ReadLine();
        }
    }
}