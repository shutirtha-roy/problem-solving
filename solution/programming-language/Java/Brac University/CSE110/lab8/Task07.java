import java.util.Scanner;
public class Task07{
    public static void main (String[]args){
        Scanner sc=new Scanner(System.in);
        System.out.println("Enter line");
        int line=sc.nextInt();
        for(int lineCount = 1; lineCount<=line ; lineCount++){
            for(int count = 1; count<=(line-lineCount); count++){
                System.out.print(" ");
            }
            int loopCount= 1;
            while(loopCount<=lineCount){
                System.out.print("*");                
                loopCount++;
            }
            System.out.println();
        }
        
    }
}