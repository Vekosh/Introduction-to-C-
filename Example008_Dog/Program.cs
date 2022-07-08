int count = 0;
double distance = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;
double time = 0;

int end_distance = 10;

while (distance > end_distance)
{
    if (friend == 1)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
    }

    if (friend == 2)
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count += 1;
}
Console.WriteLine("Собака пробежала "  + count + " раз ");
