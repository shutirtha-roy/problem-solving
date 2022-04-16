//Task7
import java.util.Scanner;
public class Lab9Task7 { 
  public static void main(String[] args) {
    int i = 1, min = Integer.MAX_VALUE, max = Integer.MIN_VALUE , sum = 0; 
    Scanner sc = new Scanner(System.in);
    System.out.println("Please enter a quantity");
    int q = sc.nextInt();
    while ( i <= q){
      System.out.println("Enter number");
      int num = sc.nextInt();
      if ( max < num ){
        max = num;
      }
      else if( min > num ){
        min = num;
      }
      sum += num;
      i++;
    }
    System.out.println("Max " + max);
    System.out.println("Min " + min);
    System.out.println("Avg " + (sum/q));
  }
}



