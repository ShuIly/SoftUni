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

        $end = intval($_GET['num']);

        if ($end >= 1) {
            echo "1 ";
        }
        if ($end >= 2) {
            echo "1 ";
        }

        $num1 = 1;
        $num2 = 1;
        $num3 = 2;
        for ($i = 3; $i <= $end; ++$i) {
            echo "$num3 ";
            $temp = $num3;
            $num3 += $num2 + $num1;
            $num1 = $num2;
            $num2 = $temp;
        }
    ?>
</body>
</html>