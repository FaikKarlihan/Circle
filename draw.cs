class CircleDrawer
{
    public void DrawCircle(int radius)
    {
        // Center coordinates
        double centerX = radius;
        double centerY = radius;

        // We create a square area with diameter x diameter in the drawing area
        for (int y = 0; y <= 2 * radius; y++)
        {
            for (int x = 0; x <= 2 * radius; x++)
            {
                // Calculate the distance of point (x, y) from the center
                double distance = Math.Sqrt(Math.Pow(x - centerX, 2) + Math.Pow(y - centerY, 2));

                // If the distance is close to the radius (with ±0.5 tolerance), draw an asterisk (*)
                if (Math.Abs(distance - radius) < 0.5)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine(); // Move to a new line at the end of each line
        }
    }
}
