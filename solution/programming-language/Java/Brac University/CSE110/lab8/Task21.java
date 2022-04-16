import java.util.Scanner;
public class Task21 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter Number");
        int num = sc.nextInt();
        System.out.println();
        for (int i = 0; i < num; i++) {          
            for (int count = i; count < num - 1; count++) {               
                System.out.print(" ");
            }
            for (int divcount = 1; divcount <= ((2 * i) + 1); divcount++) { 
                if (i > 0 && i < num - 1){
                    if (divcount > 1 && divcount < 2 * i + 1){
                        System.out.print(" ");
                    }
                    else
                        System.out.print(divcount);                    
                }
                else
                    System.out.print(divcount);               
            }
            System.out.println();          
        }      
    }  
}