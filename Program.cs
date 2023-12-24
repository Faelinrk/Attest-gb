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
}