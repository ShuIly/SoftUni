<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
    <form>
        N: <input type="text" name="num" />
        <input type="submit" />
    </form>
    <?php
        if (!isset($_GET['num'])) {
            exit(1);
        }

        $num = intval($_GET['num']);
        for ($i = $num; $i >= 2; --$i) {
            $isPrime = true;
            $end = sqrt($i);

            // here we use fibonacci numbers to find if num is primary
            for ($num1 = 1, $num2 = 2; $num2 <= $end; $num2 += $temp) {
                if ($i % $num2 == 0) {
                    $isPrime = false;
                    break;
                }

                $temp = $num1;
                $num1 = $num2;
            }

            if ($isPrime) {
                echo "$i ";
            }
        }
    ?>
</body>
</html>