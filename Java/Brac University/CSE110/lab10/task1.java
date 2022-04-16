//Task 1
import java.util.Scanner;
public class task1{
  public static void main(String[] args){
    Scanner sc = new Scanner(System.in);
    int a[] = new int[3];
    int sum =0;
    for(int i = 0; i < a.length ; i++){
      System.out.println("Enter number");
      a[i] = sc.nextInt();
      sum += a[i];
    }
    System.out.println(sum);
    System.out.println(a[0]);
    System.out.println(a[1]);
    System.out.println(a[2]);
  }
}