import java.util.Scanner;
public class Task23{
  public static void main (String[]args){
    Scanner scan=new Scanner(System.in);
    System.out.println("Enter a number");
    int n=scan.nextInt();
    int c;
    for(c=1;c<=n;c++){
      int j;
      for(j=1;j<=(n-c);j++){
        System.out.print(" ");
      }
      int k=1;
      while(k<=((2*c)-1)){
        if(k==1 || k==(2*c-1)){
          System.out.print(k);
        }
        else
          System.out.print(" ");
        k++;
      }
      System.out.println();
    }
    for(c=n-1;c>=1;c=c-1){
      int j;
      for(j=1;j<=(n-c);j++){
        System.out.print(" ");
      }
      int k=1;
      while(k<=((2*c)-1)){
        if(k==1 || k==(2*c-1)){
          System.out.print(k);
        }
        else
          System.out.print(" ");
        k++;
      }
      System.out.println();
    }
    
  }
}