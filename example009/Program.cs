int [] array = {1,24,34,56,65,74,83,91,83};

int n = array.Length;
int find = 83;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index = 1;
    index++; 
}

