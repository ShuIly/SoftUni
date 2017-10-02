import java.util.Scanner;

public class ThreeIntegersSum {
    private static boolean checkSum (int num1, int num2, int sum) {
        if (num1 + num2 == sum) {
            if (num1 > num2) {
                System.out.printf("%d + %d = %d\n", num2, num1, sum);
            }
            else {
                System.out.printf("%d + %d = %d\n", num1, num2, sum);
            }
            return true;
        }
        return false;
    }
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int num1 = scan.nextInt();
        int num2 = scan.nextInt();
        int num3 = scan.nextInt();

        if (!checkSum(num2, num3, num1) &&
            !checkSum(num1, num3, num2) &&
            !checkSum(num1, num2, num3)) {
            System.out.println("No");
        }
    }
}
