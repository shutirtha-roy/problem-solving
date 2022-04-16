import java.util.Scanner;
public class Task2Lab9v11 {
  public static void main(String[] args) { 
    Scanner sc = new Scanner(System.in);
    int a[] = new int[5];
    for(int i = 0; i < a.length ; i++){
      System.out.println("Enter number");
      a[i] = sc.nextInt();
    }
    int max = a[0];
    int locCount = 0;
    for(int i = 0; i < a.length ; i++){
      if( max < a[i]){
        max = a[i];
        locCount = i;
      }      
    }
    System.out.println("Max = "+ max);
    System.out.println("location " +locCount);
  }
}
  
