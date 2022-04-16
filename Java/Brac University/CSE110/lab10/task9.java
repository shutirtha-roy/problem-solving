import java.util.Scanner;
public class task9{
  public static void main(String[] args) { 
    Scanner sc =new Scanner(System.in);
    int a[]=new int[10];   
    for(int i = 0; i < a.length; i++){
      System.out.println("Enter number");
      a[i] = sc.nextInt();
    }
    System.out.println("Enter given number"); //checking
    int num = sc.nextInt();
    
    int count =0;
    for(int i = 0; i < a.length; i++){
      if(a[i] == num) {
        count = 1;
      }
    }         
    if(count == 1){
      System.out.println("Yes");
    }
    else{
      System.out.println("No");
    }
  }
}