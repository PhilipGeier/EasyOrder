using System;
using System.Diagnostics.CodeAnalysis;

namespace OrderingSystem.Domain
{
    public struct WpfInfo
    {
        public double PosX;
        public double PosY;
        public double Width;
        public double Height;
        public string Shape;
        
        private WpfInfo (double posX, double posY, double height, double width, string shape)
        {
            PosX = posX;
            PosY = posY;
            Height = height;
            Width = width;
            Shape = shape;
        }
        
        /// <summary>
        /// Converts a read-only character span that represents a WpfInfo Object to the equivalent WpfInfo Object
        /// </summary>
        /// <param name="input">The Character Span that represents the WpfInfo Object</param>
        /// <returns>The WpfInfo Object or null if unsuccessful</returns>
        public static WpfInfo? Parse(string input)
        { 
            string[] splitString = input.Split(",");
            try
            {
                return new WpfInfo()
                { 
                    PosX = double.Parse(splitString[0]),
                    PosY = double.Parse(splitString[1]),
                    Height = double.Parse(splitString[2]),
                    Width = double.Parse(splitString[3]),
                    Shape = splitString[4]
                };
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public static WpfInfo Create(double posX, double posY, double height, double width, string shape)
        {
            return new WpfInfo(posX, posY, height, width, shape);
        }
        
        public override string ToString() => $"{PosX},{PosY},{Height},{Width},{Shape}";

    }
}