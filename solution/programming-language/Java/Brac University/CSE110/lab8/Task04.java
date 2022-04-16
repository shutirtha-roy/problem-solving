import java.util.Scanner;
public class Task04{
    public static void main (String[]args){
        Scanner sc=new Scanner(System.in);
        System.out.println("Enter line");
        int line=sc.nextInt();
        System.out.println("Enter number");
        int number=sc.nextInt();
        for(int lineCount=1 ; lineCount<=line ;lineCount++){
            for(int count = 1 ; count <= number; count++){
            System.out.print(count);
            }
            System.out.println();
        }
        
    }
}