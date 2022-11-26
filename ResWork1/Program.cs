//Написать программу, которая из массива строк сформирует массив со строками не более 3 знаков в длину

string[] StartArray = GetStartArray(5);
Console.Write("['");
Console.Write(String.Join("', '", StartArray));
Console.WriteLine("']");

int LengthFinishArray = GetLengthFinishArray(StartArray);


if ( LengthFinishArray == 0){
    Console.WriteLine("В заданном массиве нет строк с длиной 3 символа и меньше");
}
else{
string[] FinishArray = GetFinishArray(StartArray);
Console.Write("['");
Console.Write(String.Join("', '", FinishArray));
Console.WriteLine("']");
}


string[] GetStartArray (int size){
    string[] startarray = new string[size];
    for (int i = 0; i < size; i++){
        Console.WriteLine("Введите  любое слово, число, сочетание цифр,знаков или букв");
        startarray[i] = Console.ReadLine()!;
    }
    return startarray;
}

int GetLengthFinishArray (string[] array){
    int result = 0;
    for (int i = 0; i < array.Length; i++){
        string temporary = array[i];
        if (temporary.Length <= 3){
            result += 1;
        }
        
    }
    return result;
}



string[] GetFinishArray (string[] array){
    string[] finisharray = new string[LengthFinishArray];
    int j = 0;
    for (int i = 0; i < array.Length; i++){
        string temporary = array[i];
        if (temporary.Length <= 3){
            finisharray[j] = array[i];
            j++;
        }
    }
    return finisharray;
}