// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.Clear();
int[] arr = GetArray(8);
Console.WriteLine($"[{String.Join(", ", arr)}]");

int[] GetArray(int size){
    int[] array = new int[size];
    for (int i =0; i< size; i++){
        array[i]= new Random().Next(-100,101);
    }
    return array;
}