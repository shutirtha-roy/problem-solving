import java.util.Scanner;
public class Task06{
    public static void main (String[]args){
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter number");
        int number =sc.nextInt();
        for(int lineCounter = 1; lineCounter <= number; lineCounter++){
            for(int count = 1; count<=lineCounter; count++ ){
            System.out.print(count);
            }
            System.out.println();
        }
        
    }
}