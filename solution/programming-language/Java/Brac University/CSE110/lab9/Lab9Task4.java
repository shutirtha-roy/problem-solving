//lab9task4
public class Lab9Task4 {
  public static void main(String[] args) { 
    int i = 1, sum = 0;
    while( i<= 600 ){
      if( i % 7 == 0 && i % 9 != 0) {
        sum += i;
      }     
      else if(i % 9 == 0 && i % 7 != 0){
        sum+= i;
      }
      i++;
    }
    System.out.println(sum);
  }
}