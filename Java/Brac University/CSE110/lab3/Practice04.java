import java.util.Scanner;
public class Practice04 {
    
    //task4
    public static void main(String[] args) { 
        Scanner sc = new Scanner(System.in);
        
         System.out.println("Please enter the value of radius");
         double r = sc.nextDouble();
         double area = 3.14159 * r * r;
         double circum = 2 * 3.14159 * r;
         System.out.println("Area: " +area + " Circumference: " +circum );
    }
}