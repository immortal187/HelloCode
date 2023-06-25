int [] array = {2,4,5,543,5,6,10,1};

int n = array.Length;
int index = 0;

int find = 5;



while (index < n) 
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }

    index++;    
}