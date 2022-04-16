import java.util.Scanner;
public class Task10{
  public static void main (String[]args){
    Scanner sc=new Scanner(System.in);
    System.out.println("Enter line");
    int line =sc.nextInt();
    int n;
    for(int lineCount = 1 ; lineCount <= line ; lineCount++){
      int j;
      for(j=1;j<=(line - lineCount);j++){
        System.out.print(" ");
      }
      int loopCount=1;
      while(loopCount<=(( 2*lineCount )-1)){
        System.out.print(lineCount);
        loopCount++;
      }
      System.out.println();
    }
  }
}