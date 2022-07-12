int [] array = {9, 13, 18, 4, 7, 19, 18, 31, 61};

int n = array.Length;
int find = 18;

int index = 0;

while(index < n)
{
    if( array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index += 1;
}