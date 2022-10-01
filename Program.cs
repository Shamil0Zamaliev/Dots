using Dots;

Dot d1 = new (1, 2, 3);
Dot d2 = new (1, 2, 3);
d1.X = 10;
d2.Y = 3;
Console.WriteLine(d1.Dist0());
Console.WriteLine(Dot.Distance_between(d1, d2));
Dot d3 = d1 + d2;
Dot d4 = d1 * d3;
d1.Show();
d2.Show();
d3.Show();
d4.Show();
Dot.straigh_line_equation(d1, d3);
Dot.plane_equation(d1, d2, d3);





