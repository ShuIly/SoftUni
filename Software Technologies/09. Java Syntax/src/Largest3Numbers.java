import java.util.Arrays;
import java.util.Scanner;

public class Largest3Numbers {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String input = scan.nextLine();
        int[] nums = Arrays
                .stream(input.split("\\s"))
                .mapToInt(Integer::parseInt)
                .toArray();

        Arrays.sort(nums);

        for (int i = 0; i < 3 && i < nums.length; ++i) {
            System.out.print(nums[nums.length - i - 1] + " ");
        }
    }
}
