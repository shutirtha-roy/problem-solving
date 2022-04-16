public class Task8Lab9v11{
  public static void main (String [] args) {
    Scanner sc = new Scanner (System.in);
    String array[]={" zero" ,"one" ,"two" ,"three" ,"four" ,"five" ,"six" ,"seven" ,"eight" ,"nine" };
    System.out.println("Enter a number");
    int num=sc.nextInt();
    if(( num >=0 )&&( num <= 9)){
      System.out.println(array[num]);
    }
  }
}
