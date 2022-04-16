import java.util.Scanner;
public class task11{
  public static void main(String arg[]){
    Scanner sc =new Scanner(System.in);
    int a[]=new int[10];
    System.out.println("Enter a number");
    a[0] = sc.nextInt();        
    for (int i =1 ; i < a.length ; i++){
      a[i] = sc.nextInt();
      for(int c = 0 ; c < i; c++ ){
        if( a[i] == a[c] ){
          i--;
          System.out.println("Please enter another number");
        }
      }
    }
  }
}
      
      
      
      
      
      
   /*   while(c < i){
        if( a[i] == a[c] ){
          i--;
          System.out.println("Please enter another number");
        }
        c++;
      }
    }
  } 
}

*/