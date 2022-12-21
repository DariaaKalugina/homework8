int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void WriteArray (int[,,] matrix3)
{
  for (int i = 0; i < matrix3.GetLength(0); i++)
  {
    for (int j = 0; j < matrix3.GetLength(1); j++)
    {
      for (int k = 0; k < matrix3.GetLength(2); k++)
      {
        Console.Write( $"{matrix3[i,j,k]} ({i}, {j}, {k}) ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void CreateArray(int[,,] matrix3)
{
  int[] temp = new int[matrix3.GetLength(0) * matrix3.GetLength(1) * matrix3.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 101);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 101);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < matrix3.GetLength(0); x++)
  {
    for (int y = 0; y < matrix3.GetLength(1); y++)
    {
      for (int z = 0; z < matrix3.GetLength(2); z++)
      {
        matrix3[x, y, z] = temp[count];
        count++;
      }
    }
  }
}
Console.WriteLine($"\nВведите размер массива X x Y x Z:");
int x = InputNumbers("Введите X: ");
int y = InputNumbers("Введите Y: ");
int z = InputNumbers("Введите Z: ");

int[,,] matrix3 = new int[x, y, z];
CreateArray(matrix3);
Console.WriteLine("Конечный массив: ");
WriteArray(matrix3);
