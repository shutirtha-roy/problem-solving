import java.io.*;
public class Main {
    public static void main(String[] args) throws IOException{
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        int X = -1;
        while(true){
            X = Integer.parseInt(br.readLine());
            if(X == 0) break;
            if(X % 2 != 0){
                X += 1;
            }
            X = X + (X+2) + (X+4) + (X+6) + (X+8);
            System.out.println(X);
        }
    }   
}