import java.io.*;
public class Main {
    public static void main(String[] args) throws IOException{
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        int coelho = 0 ,rato = 0 ,sapo = 0, N , Amount = 0 , total = 0;        
        N = Integer.parseInt(br.readLine());
        String[] pair;
        String animal;
        for (int i = 0; i < N; i++) {
            pair = br.readLine().split(" ");
            Amount = Integer.parseInt(pair[0]);
            animal = pair[1];
            if(animal.equals("C")) coelho += Amount;
            else if(animal.equals("R")) rato += Amount;
            else if(animal.equals("S")) sapo += Amount;
            total += Amount;
        }
        System.out.println("Total: " + total + " cobaias");
        System.out.println("Total de coelhos: " + coelho);
        System.out.println("Total de ratos: " + rato);
        System.out.println("Total de sapos: " + sapo);
        System.out.printf("Percentual de coelhos: %.2f %%\n", (100 * coelho/(double)total));
        System.out.printf("Percentual de ratos: %.2f %%\n", (100 * rato/(double)total));
        System.out.printf("Percentual de sapos: %.2f %%\n", (100 * sapo/(double)total));
    }
}