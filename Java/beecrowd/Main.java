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
    int n = sc.nextInt();
    int count = 1;
    double a = 0;
    double b = 0;
    double result = 0;
    int c = 0;
    int d = 0;
    while(count <= n){
      a = sc.nextDouble();
      b = sc.nextDouble();
      if(b == 0.0){
         c = (int)a;
         d = (int)b;
        }
      try{
        if(b == 0.0) result = c/d;
        result = a/b; 
        System.out.println(result);
      }
      catch(Exception e){
        System.out.println("divisao impossivel");
      }
      count++;
    }
    }
}