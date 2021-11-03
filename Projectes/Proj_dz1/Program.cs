//Cформировать случайным образом целочисленный массив A из натуральных двузначных чисел. Создать на его основе масив B, отбрасывая те, которые

//нарушают порядок возрастания
//больше среднего арифметического элементов A
//чётные
// Задача
// Cформировать случайным образом целочисленный массив A
// из натуральных двузначных чисел.

// Создать на его основе масив B, отбрасывая те, которые
// 1  нарушают порядок возрастания
// 2  больше среднего арифметического элементов A
// 3  чётные
 

// Задать массив

int index = 0;
int[] array = new int[10];

while (index < 10)
{
    array[index] = new Random().Next(10, 100);
    index++;
}
index = 0;

while (index <=9)
{
    int val = array[index];
    Console.WriteLine(val);
    index++;
}
Console.WriteLine();
index = 1;
// Исключение элементов нарушения возрастания
int currentElement = array[0];
Console.WriteLine(currentElement);
while (index <= 9)
{
    if(array[index]>currentElement)
      {
          Console.WriteLine(array[index]);
          currentElement = array[index];
      } 
    index++;
}
//Исключаем элементы большие среднего арифметического массива (А)
index = 0;
int rezult = array.Length;
int sum = 0;
while (index < rezult)
  {
    sum = sum + array [index];
    index++;
  }
int average = sum/rezult;
Console.WriteLine("находим среднее арифметическое");
Console.WriteLine(average);
// выводим четные числа
Console.WriteLine("выводим четные числа");
index = 0;
while (index <= 9)
{
  if(array[index] % 2 == 0 )
     {
      Console.WriteLine (array[index]);
     }
   index++;
}


