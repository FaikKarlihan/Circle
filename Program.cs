/*
Write an application to the console that draws a circle according to the radius received from the user.
*/

//Made by ChatGPT

Console.WriteLine("Please enter the radius of the circle:");
if (int.TryParse(Console.ReadLine(), out int radius) && radius > 0)
{
CircleDrawer circleDrawer = new CircleDrawer();
circleDrawer.DrawCircle(radius);
}
else
{
Console.WriteLine("Please enter a valid positive integer for the radius.");
}