// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] array = {"Hello", "2", "world", ":-)"};
string[] endArray = new string[array.Length];
int index = 0;


for(int i = 0; i < array.Length;i++){
    if(array[i].Length <= 3){
        index += 1;
        endArray[index] = array[i];
    }

}
Console.WriteLine("[{0}]", string.Join(", ", array));
Console.WriteLine("[{0}]", string.Join(", ", endArray));