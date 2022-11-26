//

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