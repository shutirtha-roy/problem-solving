//Task 2
import java.util.Scanner;
public class task2{
  public static void main(String[] args){
    Scanner sc = new Scanner(System.in);
    int a[] = new int[10];
    int sum =0;
    for(int i = 0; i < a.length ; i++){
      System.out.println("Enter number");
      a[i] = sc.nextInt();
    }
    for(int i=0; i < a.length ; i++){
      System.out.println("Enter the number");
      i = sc.nextInt();
      System.out.println(a[i]);
      break;
    }
  }
}