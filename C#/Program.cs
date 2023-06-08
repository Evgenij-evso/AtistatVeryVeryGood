int sum = 0;
int[] array = {2, 5, 13, 7, 6, 4};

for(int i = 0; i < array.Length; i++){
    sum += array[i];
}
sum /= array.Length;

Console.WriteLine(sum);