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
    
        boolean flag = true;
        double marks = 0;
        double newMarks = 0;
        double media;
        int count = 1;
        while(flag == true && count<=2){
          marks = sc.nextDouble();
          if(marks >= 0 && marks <= 10){
            newMarks += marks;
            count++;
          }
          else{
            System.out.println("nota invalida");
          }
        }
        media = newMarks / 2;
        System.out.println("media = " + media);
 
    }
 
}