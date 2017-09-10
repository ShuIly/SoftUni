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

        $num1 = 1;
        $num2 = 1;
        $end = intval($_GET['num']);
        if ($end > 0) {
            echo "1 ";
            for ($i = 2; $i <= $end; ++$i) {
                echo "$num2 ";
                $temp = $num2;
                $num2 += $num1;
                $num1 = $temp;
            }
        }
    ?>
</body>
</html>