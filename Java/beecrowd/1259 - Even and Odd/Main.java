import java.io.IOException;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Arrays;
class Main{
  
  public static void main(String[] args) throws IOException{
    java.util.Scanner sc = new java.util.Scanner(System.in);
    
    ArrayList<Integer> arrEven = new ArrayList<Integer>();
    ArrayList<Integer> arrOdd = new ArrayList<Integer>();
    int n = sc.nextInt();
    int number = 0;
    for(int i = 0; i < n ; i++){
      number = sc.nextInt();
      if(number % 2 == 0) arrEven.add(number);
      else arrOdd.add(number);
    }
    Collections.sort(arrEven);
    Collections.sort(arrOdd);
    Collections.reverse(arrOdd);
    for(int i: arrEven) System.out.println(i);
    for(int i: arrOdd) System.out.println(i);
  }
}