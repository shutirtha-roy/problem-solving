import java.util.Scanner;

public class Task9cLab9v11 {
  public static void main(String[] args) {
    Scanner sc= new Scanner(System.in);
    int a[]=new int[15];
    int b[]=new int[10];
    int i,c,count ;
    for( c=0 ; c<15 ; c++) {
      a[c]=var.nextInt();
    for(i=0;i<10;i++) {
        if(a[c]==i) {
          b[i]++;
        }
      }
    }
    for( i=0 ; i<10 ; i++) {
      System.out.println( i + " was entered "+ b[i] +" times");
    }
  }
}