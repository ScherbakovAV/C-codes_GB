int firstSpeed = 4, secondSpeed = 5, dogspeed = 10;
int friend = 2;
int count = 0, distance = 1000, time = 0;

while(distance > 10)
{
    if(friend == 1)
    {
       time = distance / (firstSpeed + dogspeed);
       friend = 2;

    }
    if(friend == 2)
    {
        time = distance / (secondSpeed + dogspeed);
        friend = 1;
    }
distance = distance - time * (firstSpeed + secondSpeed);
count += 1;
}
Console.Write("Собака пробeжит ");
Console.Write(count);
Console.Write("раз");