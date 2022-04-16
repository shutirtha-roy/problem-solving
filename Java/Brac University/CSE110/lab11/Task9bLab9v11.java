import java.util.Scanner;

public class Task9bLab9v11 {
  public static void main(String[] args) {
    Scanner sc= new Scanner(System.in);
    int a[]=new int[15];
    int i,c;
    int zeroc=0,onec=0,twoc=0,threec=0,fourc=0,fivec=0,sixc=0,sevenc=0,eightc=0,ninec=0;
    for(c=0;c<15;c++) {
      a[c]=var.nextInt();
      if(a[c]==0) {
        zeroc++;
      }
      else if(a[c]==1) {
        onec++;
      }
      else if(a[c]==2) {
        twoc++;
      }
      else if(a[c]==3) {
        threec++;
      }
      else if(a[c]==4) {
        fourc++;
      }
      else if(a[c]==5) {
        fivec++;
      }
      else if(a[c]==6) {
        sixc++;
      }
      else if(a[c]==7) {
        sevenc++;
      }
      else if(a[c]==8) {
        eightc++;
      }
      else if(a[c]==9) {
        ninec++;
      }
      }
      System.out.println("0 was entered "+zeroc+" times");
      System.out.println("1 was entered "+onec+" times");
      System.out.println("2 was entered "+twoc+" times");
      System.out.println("3 was entered "+threec+" times");
      System.out.println("4 was entered "+fourc+" times");
      System.out.println("5 was entered "+fivec+" times");
      System.out.println("6 was entered "+sixc+" times");
      System.out.println("7 was entered "+sevenc+" times");
      System.out.println("8 was entered "+eightc+" times");
      System.out.println("9 was entered "+ninec+" times");
    }
}