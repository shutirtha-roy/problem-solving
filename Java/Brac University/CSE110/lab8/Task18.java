import java.util.Scanner;
public class Task18{
  public static void main(String[] args) {
    Scanner sc = new Scanner(System.in);
    System.out.println("Enter Number");
    int num = sc.nextInt();
    System.out.println();
    for (int i = num; i >= 1; i--) {            
      for (int j = 1; j < i; j++) {
        System.out.print(" ");
      }
      for (int count = i; count <= num ; count++) {
        if (i > 1 && i < num - 1) {
          if (count > i && count < num) {
            System.out.print(" ");
          } 
          else{
            System.out.print("*");
          }
        } 
        else{
          System.out.print("*");
        }
      }
      System.out.println();
    }
    
  }
  
}