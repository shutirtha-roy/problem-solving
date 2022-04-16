//lab9task1d
public class Lab9Task1d {
  public static void main(String[] args) { 
    int i = 1, sum = 18;
    while( i<= 6 ){
      if( i % 2 == 0){
      System.out.println(-sum);
      }
      else{
        System.out.println(sum);
      }
      sum += 9;
      i++;
    }
  }
}
    
    
    