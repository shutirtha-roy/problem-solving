import java.util.Scanner;
public class Task6Lab9v11{
  public static void main (String [] args) {
    Scanner sc = new Scanner (System.in);
    System.out.println("Enter quantity");
    int q=sc.nextInt();
    int a[]=new int [q];
    for( int c=0 ; c < q ; c++) {
      System.out.println("Enter number");  
      a[c]=sc.nextInt();
    }
    for (int i=0 ; i < q ; i++) {
      for (int j=i ; j < q ; j++) {
        if (a[i] > a[j]) {
          int temp = a[i];
          a[i] = a[j];
          a[j] = temp;
        }
      }
    }
    if ( q % 2 == 0) {
      int s = q / 2;
      int s1 = s-1;
      int r = ( a[s]+a[s1] )/2;
      System.out.println(r);
    }
    else {
      int r = q /2;22464
      System.out.println(a[r]);
    }
  }
}