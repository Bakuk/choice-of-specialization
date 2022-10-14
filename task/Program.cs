int len = 10;
string[] array = { "1234", "1567", "-2", "computer science" };
string[] newArr = new string[len];

string[] ConvertArray(string[] arr){
    string[] newArr = new string[arr.Length];
    int j = 0;
    for (int i = 0; i< arr.Length; i++){
        string temp = arr[i];
        if(temp.Length <= 3){
            newArr[j] = temp;
            j++;
        }
    }
    return newArr;
}

void PrintArray(string[] arr){
    for(int i = 0; i<arr.Length; i++){
        Console.WriteLine(arr[i]);
    }
}

newArr = ConvertArray(array);
PrintArray(newArr);