int day , time;
day = int.Parse(Console.ReadLine());
time = int.Parse(Console.ReadLine());
int late , weekend;
int breakfastCount = 5 , WeeknendCount = 2 , coffeeCount = 3;
string order;
bool isEnd = false;

while(!isEnd)
{
    order = Console.ReadLine();
    switch (order)
    {
        case "Breakfast Set" :
            if(breakfastCount > 0)
            {
                breakfastCount--;
                break;
            }
            else if(time > 11)
            {
                Console.WriteLine("Sorry your order is not available");
                break;
            }
            Console.WriteLine("Sorry your order is out of stock");
            break;
        case "Weekend Set" :
        if(WeeknendCount > 0)
            {
                WeeknendCount--;
                break;
            }
            else if(day > 0 && day < 6 )
            {
                Console.WriteLine("Sorry your order is not available");
                break;
            }
            Console.WriteLine("Sorry your order is out of stock");
            break;
        case "Coffee" :
            if(coffeeCount > 0)
            {
                coffeeCount--;
                break;
            }
            Console.WriteLine("Sorry your order is out of stock");
            break;
        case "End" :
            isEnd = true;
            break;
        default:
            Console.WriteLine("Please enter a valid menu");
            break;
    }
}

