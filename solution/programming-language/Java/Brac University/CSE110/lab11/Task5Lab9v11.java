import java.util.Scanner;
public class Task5Lab9v11 {
  public static void main(String[] args) { 
    Scanner sc = new Scanner(System.in);
     int a[] = new int[5];
     for(int i = 0; i < a.length ; i++){
     System.out.println("Enter number");
     a[i] = sc.nextInt();
     }     
    for(int i = 0; i < a.length; i++){
      int min = a[i];
      int minLocation = i;
      for(int j = i + 1; j < a.length ; j++){
        if( min < a[j] ){
          min = a[j];
          minLocation = j;
        }
      }
      int temp = a[i];
      a[i] = a[minLocation];
      a[minLocation] = temp;
      
    }
    for( int i = 0; i < a.length; i++){
      System.out.println(a[i]);
    }
  }
}
