import java.util.Scanner;
public class Task24{
    public static void main (String[]args){
        Scanner sc=new Scanner(System.in);
        System.out.println("Enter A Number");
        int num=sc.nextInt();
        for(int count=1;count<=num;count++){
            System.out.print(count);
        }
        for(int count = num - 1 ; count >= 1 ; count--){
        System.out.print(count);
        }
        System.out.println();       
    }
}