//Task8
import java.util.Scanner;
public class Lab9Task8 { 
  public static void main(String[] args) {
    Scanner sc = new Scanner(System.in);
    int i = 1, divCount =0;
    System.out.print("Enter number");
    int num = sc.nextInt();
    while ( i <= num){
      if( num % i == 0){
        System.out.println(i);
        divCount++;
      }
      i++;
    }
    System.out.println(divCount + " divisors");
  }
}
      