//lab9task3
public class Lab9Task3 {
  public static void main(String[] args) { 
    int i = 1, sum = 0;
    while( i<= 600 ){
      if( i % 7 == 0 || i % 9 == 0) {
        sum += i;
      }
      i++;
    
    }
    System.out.println(sum);
  }
}