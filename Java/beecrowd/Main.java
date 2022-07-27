import java.io.IOException;
 
/**
 * IMPORTANT: 
 *      O nome da classe deve ser "Main" para que a sua solução execute
 *      Class name must be "Main" for your solution to execute
 *      El nombre de la clase debe ser "Main" para que su solución ejecutar
 */
public class Main {
 
    public static void main(String[] args) throws IOException {
 
        java.util.Scanner sc = new java.util.Scanner(System.in);
    
        int[] array = new int[1000];
        int T = sc.nextInt();
        int i = 0;
        for(int j = 0 ; j < array.length ; j++){
            System.out.println("N[" + j + "] = " + i);
            i++;
            if(i % T == 0) i = 0;
          }
 
    }
 
}