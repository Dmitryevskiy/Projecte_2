int[] array = { 1, 22, 13, 3, 65, 54, 2, 22 };

int n = array.Length;
int find = 22;

int index = 0;

while (index < n)
{

    if(array[index] == find)
    {
      Console.WriteLine(index);
      break;  
    }
    index = index + 1;
}
