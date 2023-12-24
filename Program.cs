class Program{
    static void Main(string[] args){
        string[] firstArray = {"Арбузы", "Бананы", "Мак", "Акакий", "Три"};
    }
    static int CountNumEnements(string[] array, int elementLen){
        int count = 0;
        for (int i = 0; i < array.Length; i++){
            if (array[i].Length <= elementLen){
                count ++;
            }
        }
        return count;
    }
    static string[] FilterArrayToArray(string[] oldArray, int elementLen){
        int newArrayLen = CountNumEnements(oldArray, elementLen);
        string[] newArray = new string[newArrayLen];
        int newElementIndex = 0;
        for (int i = 0; i < oldArray.Length; i++){
            if (oldArray[i].Length <= elementLen){
                newArray[newElementIndex] = oldArray[i];
                newElementIndex++;
            }
        }
        return newArray;
    }
}