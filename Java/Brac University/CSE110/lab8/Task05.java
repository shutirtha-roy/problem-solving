import java.util.Scanner;
public class Task05{
    public static void main (String[]args){
        Scanner sc=new Scanner(System.in);
        System.out.println("Enter line");
        int line=sc.nextInt();
        for(int lineCounter = 1; lineCounter <= line; lineCounter++){
            for(int count = 1; count<=lineCounter; count++ ){
            System.out.print("*");
            }
            System.out.println();
        }
        
    }
}