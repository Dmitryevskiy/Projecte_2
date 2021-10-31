Console.WriteLine("hello guy");
int count = 0;
int distanse = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;
int time = 0;

while  (distanse > 10)
{
    if (friend == 1)
    {
        time = distanse/(firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        time = distanse/(secondFriendSpeed + dogSpeed);
        friend = 1;
    } 

    distanse = distanse-(firstFriendSpeed+secondFriendSpeed)*time;
    count = count+1;
}

Console.WriteLine ($"Собака пробежит {count} раз");
   



