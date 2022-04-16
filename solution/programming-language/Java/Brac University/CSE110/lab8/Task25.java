import java.util.Scanner;
public class Task25{
    public static void main (String[]args){
        Scanner sc=new Scanner(System.in);
        System.out.println("Enter a number");
        int num = sc.nextInt();
        for( int i=1; i <=num ; i++){
            int j;
            for(int count=1 ; count <= num - i ; count++){
                System.out.print(" ");
            }
            for(int divcount= 1 ; divcount <= i ; divcount++){
                System.out.print(divcount);
            }
            for( int divcount = i - 1 ; divcount >= 1 ; divcount--){
                System.out.print(divcount);
            }
            System.out.println();
        }
        
    }
}