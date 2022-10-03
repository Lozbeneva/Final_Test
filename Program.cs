
string[] source = {"Hello", "22", "world", ":-)"};
int searchSize=3; //количество символов в строке для поиска. По условию задачи это 3 
int newArraySize = 0; //счетчик количества удовлетворяющих условие элементов

foreach (string element in source)
{
    if (element.Length <= searchSize)
    {
        newArraySize++;
    }
}

if (newArraySize != 0)
{
    string[] destination = new string[newArraySize];
    int k = 0;

    foreach (string element in source)
    {
        if (element.Length <= searchSize)
        {
            destination[k] = element;
            k++;
        }
    }
    Console.Write(String.Join(",", destination));
}
else
{
    Console.WriteLine("В массиве нет удовлетворяющих условие элементов");
}