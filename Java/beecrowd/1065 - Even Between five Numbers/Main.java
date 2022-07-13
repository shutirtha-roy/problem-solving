import java.io.*;
public class Main {
    public static void main(String[] args) throws IOException{
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        int count = 0;
        for (int i = 0; i < 5; i++) {
            int N = Integer.parseInt(br.readLine());
            if(N % 2 == 0) count++;
        }
        System.out.println(count + " valores pares");
    }
}