//task6
import java.util.Scanner;
public class Lab9Task6{
  public static void main(String[] args){
    Scanner sc = new Scanner(System.in);
    System.out.println("Enter quantity");
    int q = sc.nextInt();
    int i = 1;
      while(i <= q){
      System.out.println("Enter number");
      int num = sc.nextInt();
      if(num % 2 != 0){
        System.out.println("odd");
      }
      else{
        System.out.println("even");
      }
      i++;
    }
  }
}
         
         