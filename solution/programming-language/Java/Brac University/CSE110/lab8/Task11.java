import java.util.Scanner;
public class Task11{
    public static void main (String[]args){
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter a number");
        int num = sc.nextInt();
        for(int lineCount=num; lineCount >= 1; lineCount = lineCount-1){
            for(int count=1; count<=lineCount-1; count++){
                System.out.print(" ");
            }
            int loopCount=lineCount;
            while(loopCount <= num ){
                System.out.print(loopCount);
                loopCount++;
            }
            System.out.println();
        }
        
    }
}