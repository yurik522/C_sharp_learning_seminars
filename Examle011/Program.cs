int[] array = new int[12]; 
int len = array.Length;
int index = 0;
int res = 0;
int resneg = 0;
while(index < len)
{
    array[index] = new Random().Next(-9,10);
    index++;
}
for (int i=0; i < len; i++)
{
if (array[i] < 0){
  resneg += array[i];

} else {
  res += array[i];
}
Console.WriteLine($"{array[i]}");
}
Console.WriteLine("");
Console.WriteLine($"сумма положительных = {res}, сумма отрицательных = {resneg}");