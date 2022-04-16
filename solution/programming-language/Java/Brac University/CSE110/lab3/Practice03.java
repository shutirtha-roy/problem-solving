import java.util.Scanner;
public class Practice03 {
    
    //Task2
    public static void main(String[] args) { 
        Scanner sc = new Scanner(System.in);
        
         System.out.println("Please Enter 1st number");
         float var1 = sc.nextFloat();
         System.out.println("Var1 :"  +var1);
         System.out.println("Please Enter 2nd number");
         float var2 = sc.nextFloat();
         System.out.println("Var2 :"  +var2);
         float sum = var1 + var2;
         float product = var1 * var2;
         float diff = var1 - var2 ;
         System.out.println("Sum :" + sum + " Product :" + product + " difference: " + diff); 
}
}
