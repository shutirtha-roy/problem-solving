//Task9
import java.util.Scanner;
public class Lab9Task9 { 
  public static void main(String[] args) {
    Scanner sc = new Scanner(System.in);
    System.out.println("Enter number");
    int num = sc.nextInt();
    int i = 1, sum = 0;
    while( i < num){
      if ( num % i == 0){
        sum += i;
      }
      i++;
    }
      if( num == sum){
        System.out.println("Perfect number");
      }
      else{
        System.out.println("not perfect");
      }
    }
  }