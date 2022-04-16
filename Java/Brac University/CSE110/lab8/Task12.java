import java.util.Scanner;
public class Task12{
    public static void main (String[]args){
        Scanner sc=new Scanner(System.in);
        System.out.println("Enter line");
        int line = sc.nextInt();
        for(int lineCount =1; lineCount<=line; lineCount++){
            int count;
            for( count=1; count<=(line-lineCount);count++){
                System.out.print(" ");
            }
            int loopCount = 1;
            while( loopCount <=((2*lineCount)-1)){
                System.out.print("*");
                loopCount++;
            }
            System.out.println();
        }
            for(int lineCount=line-1;lineCount>=1;lineCount=lineCount-1){            
            for(int j=1;j<=(line-lineCount);j++){
                System.out.print(" ");
            }
            int loopCount = 1;
            while(loopCount <=((2*lineCount)-1)){
                System.out.print("*");
                loopCount++;
            }
            System.out.println();
        }
        
    }
}