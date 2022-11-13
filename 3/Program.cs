// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента
 
 
int[, ,]cube = new int[3, 3, 3];

void FillArray(int[, ,]cube)
{
    int count = 10;
    for(int i = 0; i < cube.GetLength(0); i ++)
    {
        for(int j = 0; j < cube.GetLength(1); j ++)
        {
            for(int k = 0; k < cube.GetLength(2); k ++)
            {   
               count ++; 
               cube[i, j, k] = count;
            }
        }
        
    }
    
}
 
void PrintArray(int[, ,]cube)
{
    for(int i = 0; i < cube.GetLength(0); i ++)
    {
        
        for(int j = 0; j < cube.GetLength(1); j ++)
        {
            
            for(int k = 0; k < cube.GetLength(2); k ++)
            {
                Console.WriteLine($"Элемент с индексом i = {i}, j = {j}, k = {k}  ={cube[i, j, k]}");
            }
        }
        
    }
    
}

FillArray(cube);
PrintArray(cube);