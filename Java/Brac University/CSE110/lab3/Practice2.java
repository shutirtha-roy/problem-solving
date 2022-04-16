import java.util.Scanner;
public class Practice2 {
    
    //Task2
    public static void main(String[] args) { 
        Scanner sc = new Scanner(System.in);
        
         System.out.println("Please Enter 1st number");
         int var1 = sc.nextInt();
         System.out.println("Var1 :"  +var1);
         System.out.println("Please Enter 2nd number");
         int var2 = sc.nextInt();
         System.out.println("Var2 :"  +var2);
         int sum = var1 + var2;
         int product = var1 * var2;
         int diff = var1 - var2 ;
         System.out.println("Sum :" + sum + " Product :" + product + " difference: " + diff); 
}
}
