import java.util.Scanner;
public class Task17{
    public static void main (String[]args){
        Scanner sc=new Scanner(System.in);
        System.out.println("Enter a number");
        int number =sc.nextInt();
        for ( int i=1 ; i<=number ; i++ ) {
         for ( int j=1 ; j <= i ; j++ ) {
           if(i==1 || i==2 || i == number || j == 1 | j == i){
              System.out.print(j);
           }
           else{ 
              System.out.print(" ");
           }
         }
         System.out.println();
      }
        
    }
}