public class Lab9Task11 { 
  public static void main(String[] args) {
    
    
    int n = 40;
    while(n <= 50){
      int divCount = 0;
      int i = 1;
      while( i <= n){
        if( n % i == 0){
          divCount++;
        }
        i++;
      }
      if(divCount == 2){
        System.out.println(n);
      }
      n++;
    }
  }
}