class Main{
  public static void main(String[] args){
    int I = 1;
    int temp = 7;
    int Jtemp = temp;
    for(int i = 1 ; I<= 9  ; i = i++){
      for(int j = 1; j <=3 ; j++){
       System.out.println("I=" + I + " J=" + temp--); 
      }
      I = I + 2;
      Jtemp += 2;
      temp = Jtemp;
  }
}
}