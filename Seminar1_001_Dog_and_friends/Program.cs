double Distance = 1000, // первоначальное расстояние между друзьями
DistanceLimit = 10, // минимальное расстояние между друзьями
FirstFriendSpeed = 4, // скорость первого друга
SecondFriendSpeed = 5, // скорость второго друга
DogSpeed = 10, // скорость собаки
MeetingTime = 0; // время встречи
int MeetingsCount = 0, // количество встреч собаки с друзьями
FriendDirection = 2; // направление движения собаки

while(Distance > DistanceLimit) // выполняем до тех пор, пока друзья не встретятся на минимальном расстоянии
{
  if(FriendDirection == 1)
  {
    MeetingTime = Distance / (FirstFriendSpeed + DogSpeed);
    FriendDirection = 2;
  }
  else
  {
    MeetingTime = Distance / (SecondFriendSpeed + DogSpeed);
    FriendDirection = 1;
  }
  Distance = Distance - MeetingTime * (FirstFriendSpeed + SecondFriendSpeed); // расстояние между первым и вторым другом после встречи одного из них с собакой
  MeetingsCount++;
  Console.Write("Дистанция встречи №");
  Console.Write(MeetingsCount);
  Console.Write("...");
  Console.WriteLine(Distance);
}
Console.Write("Количество встреч собаки и друзей: ");
Console.WriteLine(MeetingsCount);