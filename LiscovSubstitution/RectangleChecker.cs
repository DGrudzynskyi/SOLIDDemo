using System;

namespace LiscovSubstitution
{
    static class RectangleChecker {
        public static void CheckIt(Rectangle rectangle) {
            if(rectangle.Area() > 50) {
                throw new InvalidOperationException("Your rectangle is absolute beast, shut down this application");
            } else {
                Console.WriteLine("Nice tiny rectangle with area " + rectangle.Area());
            }
        }
    }
}