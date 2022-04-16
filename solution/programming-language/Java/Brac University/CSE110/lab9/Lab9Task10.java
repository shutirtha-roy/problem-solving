import java.util.Scanner;
public class Lab9Task10 { 
  public static void main(String[] args) {
    int i = 40, sum = 0, divCount = 0;
    while( i <= 50){
      if ( i % divCount == 0){
        divCount++;
      }
    }
    if ( divCount == 2 ){
      System.out.println(i);
    }
    i++;
  }
}
      
     