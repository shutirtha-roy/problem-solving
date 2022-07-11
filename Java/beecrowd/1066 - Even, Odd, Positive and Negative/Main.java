import java.io.*;
public class Main {
    public static void main(String[] args) throws IOException{
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        int countEven = 0,countOdd = 0,countPositive = 0,countNegative = 0;
        for (int i = 0; i < 5; i++) {
            int N = Integer.parseInt(br.readLine());
            if(N % 2 == 0) countEven++;
            else if(N % 2 != 0) countOdd++;
            if(N > 0) countPositive++;
            else if(N < 0) countNegative++;
        }
        System.out.println(countEven + " valor(es) par(es)");
        System.out.println(countOdd + " valor(es) impar(es)");
        System.out.println(countPositive + " valor(es) positivo(s)");
        System.out.println(countNegative + " valor(es) negativo(s)");
    }
}