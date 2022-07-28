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
    
        int X = sc.nextInt();
        int Y = sc.nextInt();
        
        
        int sum = 0;
        if(X < Y){
          for(int i = X; i <= Y ; i++){
            if(i % 13 != 0){
              sum += i; 
            }
          }
        }
        else{
          for(int i = Y; i <= X ; i++){
            if(i % 13 != 0){
              sum += i; 
            }
          }
        }
        System.out.println(sum);
 
    }
 
}