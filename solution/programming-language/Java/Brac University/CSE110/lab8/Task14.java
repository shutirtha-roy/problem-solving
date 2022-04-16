import java.util.Scanner;
public class Task14{
  public static void main (String[]args){
    Scanner sc=new Scanner(System.in);
    System.out.println("Enter length");
    int length=sc.nextInt();
    System.out.println("Enter width");
    int width=sc.nextInt();
    for(int count=1 ; count==1 ; count++){
      for( int i=1;  i<=width ; i++){
        System.out.print("*");
      }
      System.out.println();
    }
    for( int count =1 ; count<=(length-2); count++){
      System.out.print("*");
      for( int i=1 ; i<=(width-2) ; i++){
        System.out.print(" ");
      }
      System.out.print("*");
      System.out.println();
    }
    for( int count=1; count==1; count++){
      for( int i=1 ; i<=width ; i++ ){
        System.out.print("*");
      }
      System.out.println();
    }
  }
}