import java.util.Scanner;
public class Practice07 {
    
    
    public static void main(String[] args) { 
        Scanner sc = new Scanner(System.in);
        
         System.out.println("Please Enter 1st number");
        int var1 = sc.nextInt();
        System.out.println("Var1 :"  +var1);
        System.out.println("Please Enter 2nd number");
        int var2 = sc.nextInt();
        
        if (var1 > var2){
            System.out.println("first is greater");
        }else{
            if (var1 = var2) {
                System.out.println("the numbers are equal");   
            }
            else{
                System.out.println("second is greater");
            }       
            
        }
    }
}