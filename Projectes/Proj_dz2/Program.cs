//Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue]. Создать на его основе масив B, отбрасывая те, которые нарушают порядок

//возрастания
//элементы, больше 8
//знакочередования

int index = 0;
int[] array = new int[10];
int MinValue = -20;
int MaxValue = 20;
while (index < 10)  
  {
  array[index] = new Random().Next(MinValue, MaxValue);  
  index++;
  } 
index = 0;
while (index <= 9)
{
    int val = array[index];
    Console.WriteLine (val);
    index++;
}
Console.WriteLine ("Создали случайный массив");
Console.WriteLine();
index = 1;
// Отбрасываем элементы, нарушающие порядок возрастания
int carenElement = array[0];
Console.WriteLine (array[0]);
while (index <=9)
{
    if (array[index] > carenElement)
    {
        carenElement = array[index];
        Console.WriteLine (carenElement);
    }
    index++;
}
Console.WriteLine ("Отбросили элементы нарушающие порядок возрастания");
Console.WriteLine ();
// Отбрасываем элементы больше 8
index = 0;
while (index <=9)
{
    if (array [index] < 8)
    {
        Console.WriteLine (array [index]);
    }
    index++;
}
Console.WriteLine ("Отбросили элементы большие 8");
Console.WriteLine ();
// Отбрасываем нарушающие знакочередование
index =0;
carenElement = array [index];
Console.WriteLine(carenElement);
index = 1;
while (index <=9)
{
    if (carenElement < 0 && array[index] > 0 || carenElement > 0 && array[index] < 0)
    {
       Console.WriteLine (array [index]);
       carenElement = array [index];
    } 
    if (carenElement > 0 && array[index] < 0 || carenElement < 0 && array[index] > 0)
    {
       Console.WriteLine (array [index]);
       carenElement = array [index];
    } 
   index++;
}
Console.WriteLine ("Отбросили элементы нарушающие знакочередование");