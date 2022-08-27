int xa = new Random().Next(1, 10);
int ya = new Random().Next(1, 10);
int za = new Random().Next(1, 10);
int xb = new Random().Next(1, 10);
int yb = new Random().Next(1, 10);
int zb = new Random().Next(1, 10);

void Length (int xa, int ya, int za, int xb, int yb, int zb){
    Console.WriteLine(Math.Sqrt(Math.Pow((xa-xb),2)+Math.Pow((ya-yb),2)+Math.Pow((za-zb),2)));
}
Console.WriteLine($"Point A:({xa},{ya},{za})");
Console.WriteLine($"Point B:({xb},{yb},{zb})");
Console.Write("Length between points : ");
Length(xa,ya,za,xb,yb,zb);