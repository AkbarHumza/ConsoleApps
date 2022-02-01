namespace ConsoleAppProject.App01
{
    using System;
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>
    public class DistanceConverter
    {
        private int miles;
        private int feet; 
        private string value;

        public void Run()
        {
            Console.WriteLine("please enter a distance in miles");

            value = Console.ReadLine();
            miles = Convert.ToUInt16(value);

            feet = miles * 5028;

            Console.WriteLine("The Number of feet = " + feet);

        }

    }
}
