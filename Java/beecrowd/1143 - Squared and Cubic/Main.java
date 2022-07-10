import java.io.*;
public class Main {
    public static void main(String[] args) throws IOException{
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        int N = Integer.parseInt(br.readLine());
        int pow = 1;
        for(int i = 1; i <= N ; i++){
            for(int j = 1; j <= 3 ; j++){
                pow = pow * i;
                System.out.print(pow);
                if(j < 3) System.out.print(" ");
            }
            pow = 1;
            System.out.println();
        }
    }
}