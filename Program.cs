// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, my Dear !");
// Console.ReadLine();

// int[] arr = { 1, 5, 44, -11 };
// Функция печати заданного массива
// void PrintArray(int[] array)
// {
// 	for (int i = 0; i < array.Length; i++)
// 	{
// 		Console.Write($"{array[i]}  ");
// 	}//  Cортировка массива от меньшего к большему числу
// void SelectionSort(int[] array)
// {
// 	for (int i = 0; i < array.Length - 1; i++)
// 	{
// 		int minPosition = i;
// 		Console.WriteLine();
// 		Console.WriteLine();
// 		Console.WriteLine("                     i=minPosition:" + minPosition);
// 		Console.Read();
// 		for (int j = i + 1; j < array.Length; j++)
// 		{
// 			Console.WriteLine("array[j]=" + array[j] + "  ");
// 			Console.Write("array[minPosition]=" + array[minPosition] + "   ");
// 			if (array[j] < array[minPosition])
// 			{
// 				minPosition = j;
// 				Console.WriteLine("   j=minPosition=" + minPosition + "  ");
// 			}
// 		}

// 		int temporary = array[i];
// 		array[i] = array[minPosition];
// 		array[minPosition] = temporary;
// 		PrintArray(arr);
// 	}
// }
// SelectionSort(arr);
// Console.WriteLine();
// Console.WriteLine();
// PrintArray(arr);


// ___________________________________________________________________________________________
int[] arr = { 1, 5, 44, 0, -8, 345, 12 };
// Функция печати заданного массива
void PrintArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write($"{array[i]}  ");
	}
	Console.ReadLine();
}

PrintArray(arr);

// Cортировка массива от большего к меньшему числу
void SelectionSort(int[] array)
{
	for (int i = 0; i < array.Length - 1; i++)
	{
		int maxPosition = i;
		Console.WriteLine();
		Console.WriteLine("            i = maxPosition:" + maxPosition);
		Console.Read();

		for (int j = i + 1; j < array.Length; j++)
		{
			Console.WriteLine("array[j]=" + array[j] + "  ");
			Console.Write("array[maxPosition]=" + array[maxPosition] + "   ");
			if (array[j] > array[maxPosition])
			{
				maxPosition = j;
				Console.WriteLine("   j=maxPosition=" + maxPosition + "  ");
			}
		}

		int temporary = array[i];
		array[i] = array[maxPosition];
		array[maxPosition] = temporary;
		PrintArray(arr);
	}
}
SelectionSort(arr);
Console.WriteLine();
Console.WriteLine();
PrintArray(arr);

Console.ReadLine();

PrintArray(arr);


