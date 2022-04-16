import java.util.Scanner;

public class Task9aLab9v11 {
  public static void main(String[] args) {
    Scanner sc = new Scanner(System.in);
    int a[]=new int[15];
    int  i,c,count;
    for( c = 0 ; c < 15; c++ ){
      a[c]=sc.nextInt();
    }
    for(i=0;i<10;i++) {
      count=0;
      for(c=0;c<15;c++) {
        if(a[c]==i) {
          count++;
        }
      }
      System.out.println(i+" was entered "+count+" times");
    }
  }
}