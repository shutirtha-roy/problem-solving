import java.io.IOException;
import java.util.Scanner;
/**
 * IMPORTANT: 
 *      O nome da classe deve ser "Main" para que a sua solução execute
 *      Class name must be "Main" for your solution to execute
 *      El nombre de la clase debe ser "Main" para que su solución ejecutar
 */
public class Main {
 
    public static void main(String[] args) throws IOException {
        Scanner sc = new Scanner(System.in);
        int a = sc.nextInt();
        int b = sc.nextInt();
        boolean flag = true;
        while(flag){
            if(a == b) break;
            else{
              if(a > b)
                System.out.println("Decrescente");
              else
                System.out.println("Crescente");
            }
            a = sc.nextInt();
            b = sc.nextInt();
        }
    }
}