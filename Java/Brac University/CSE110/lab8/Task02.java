import java.util.Scanner;
public class Task02{
    public static void main (String[]args){
        Scanner sc =new Scanner(System.in);
        System.out.println("Enter number");
        int num = sc.nextInt();
        for(int i = 1; i <= num ; i++){
            System.out.print("*");
            
        }
        System.out.println();
    }
}