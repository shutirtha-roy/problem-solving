import java.util.Scanner;
public class Task01{
    public static void main (String[]args){
        Scanner sc=new Scanner(System.in);
        System.out.println("Enter A Number");
        int num=sc.nextInt();
        for(int i=1 ; i <= num ; i++){
            System.out.print(i);
            
        }
        System.out.println();
    }
}