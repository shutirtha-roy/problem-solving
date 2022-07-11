import java.io.*;
public class Main {
    public static void main(String[] args) throws IOException{
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        int alcohol = 0,gasoline = 0,diesel = 0,end = 4;
        int num = Integer.parseInt(br.readLine());
        while(num != end){
            if(num == 1) alcohol++;
            else if(num == 2) gasoline++;
            else if(num == 3) diesel++;
            else if(num == end) break;        
            num = Integer.parseInt(br.readLine());
        }
        System.out.println("MUITO OBRIGADO");
        System.out.println("Alcool: " + alcohol);
        System.out.println("Gasolina: " + gasoline);
        System.out.println("Diesel: " + diesel);
    }
}