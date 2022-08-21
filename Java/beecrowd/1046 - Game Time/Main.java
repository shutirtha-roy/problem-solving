import java.util.Scanner;
class Main{
  public static void main(String[] args){
    Scanner sc = new Scanner(System.in);
    int start,end,duration=0;
    start = sc.nextInt();
    end = sc.nextInt();
    if(end < start){
     duration = 24 - start + end; 
    }
    else if(start == end){
      duration = 24;
    }
    else if(start < end){
     duration = end - start; 
    }
    System.out.println("O JOGO DUROU "+duration+" HORA(S)");
    
    
  }
}