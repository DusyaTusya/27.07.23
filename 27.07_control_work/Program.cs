// Задача: 
// Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам.

string[] array = new string[7]{"hello", "3", "world", "yes", "76532", "a", "no"}; // создаем массив

int lengthNewArray = 0; // находим длину будущего массива
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3) 
    {
        lengthNewArray += 1;
    }
}

string[] NewArray(string[] array) // функция создания нового массива, заполненного элементами по условию задачи
{
string[] newArray = new string[lengthNewArray];
int j = 0;
    for (int i = 0; i < array.Length; i += 1)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j += 1;
        }
    }
return newArray;
}