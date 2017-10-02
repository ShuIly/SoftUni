import java.util.Scanner;

public class SymmetricNumbers {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int n = Integer.parseInt(scan.nextLine());
        for (int i = 1; i <= n; ++i) {
            String strNum = "" + i;
            boolean isSymmetric = true;
            for (int l = 0, r = strNum.length() - 1; l <= r; ++l, --r) {
                if (strNum.charAt(l) != strNum.charAt(r)) {
                    isSymmetric = false;
                    break;
                }
            }
            if (isSymmetric)
                System.out.print(strNum + " ");
        }
    }
}
