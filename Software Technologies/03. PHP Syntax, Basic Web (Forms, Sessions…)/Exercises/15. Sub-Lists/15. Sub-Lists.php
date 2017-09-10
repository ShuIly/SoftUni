<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
    <form>
        N: <input type="text" name="num1" />
        M: <input type="text" name="num2" />
        <input type="submit" />
    </form>
	<ul>
        <?php
            if (!isset($_GET['num1']) || !isset($_GET['num2'])) {
                exit(1);
            }
            $listNum = intval($_GET['num1']);
            $sublistNum = intval($_GET['num2']);
            for ($i = 1; $i <= $listNum; ++$i) {
                echo "    <li>List $i</br>   <ul>";
                for ($j = 1; $j <= $sublistNum; ++$j) {
                    echo "           <li>";
                    echo "               Element $i.$j";
                    echo "           </li>";
                }
                echo "       </ul>";
            }
        ?>
	</ul>
</body>
</html>