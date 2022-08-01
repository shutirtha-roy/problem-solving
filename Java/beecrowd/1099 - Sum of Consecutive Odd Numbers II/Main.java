import java.util.Scanner;
class Main{
  public static void main(String[] args){
    Scanner input = new Scanner(System.in);
    int N = input.nextInt();
    
    for(int j = 0 ; j < N ; j++){
      int X = input.nextInt();
      int Y = input.nextInt();
      int temp = 0;
      if(X > Y){
        for(int i = Y+1 ; i< X ; i++){
          if(i % 2 == 1){
            temp += i;
          }
        }
          System.out.println(temp);  
      }
      else if(X < Y){
        for(int i = X+1 ; i< Y ; i++){
          if(i % 2 == 1){
            temp += i; 
          }
        }
          System.out.println(temp);  
      }
      else{
        System.out.println('0');
      }
    }
  }
}