// See https://aka.ms/new-console-template for more information

int[] arr = {9,8,7,6,5,4,3,2,1};
      
Console.WriteLine("Reversed");
Reverse(arr).ToList().ForEach(Console.WriteLine);

int[] Reverse(int[]arr){
    int len = arr.Length - 1;
    for(int i=0;i<(int)Math.Floor((float)arr.Length/2);i++){
        (arr[i],arr[len-i])=(arr[len-i],arr[i]);
    }
      
    return arr;
}