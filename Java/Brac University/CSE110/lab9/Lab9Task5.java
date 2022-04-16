//task5
import java.util.Scanner;
public class Lab9Task5{
  public static void main(String[] args){
    Scanner sc = new Scanner(System.in);
    int i = 1;
      while(i <= 20){
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
         
         
         