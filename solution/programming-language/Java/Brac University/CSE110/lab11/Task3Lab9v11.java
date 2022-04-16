import java.util.Scanner;
public class Task3Lab9v11 {
  public static void main(String[] args) { 
    Scanner sc = new Scanner(System.in);
    int a[] = new int[5];
    for(int i = 0; i < a.length ; i++){
      System.out.println("Enter number");
      a[i] = sc.nextInt();
    }
    int max = a[0];
    int min = a[0];
    int locMaxCount = 0;
    int locMinCount = 0;
    for(int i = 0; i < a.length ; i++){
      if( max < a[i]){
        max = a[i];
        locMaxCount = i;
      }
      else if ( min > a[i] ){
        min = a[i];
        locMinCount = i;
      }
    }
      System.out.println("Max = "+ max);
      System.out.println("min = " + min);
      System.out.println("location max " +locMaxCount);
      System.out.println("location min " + locMinCount);
    }
  }
  
