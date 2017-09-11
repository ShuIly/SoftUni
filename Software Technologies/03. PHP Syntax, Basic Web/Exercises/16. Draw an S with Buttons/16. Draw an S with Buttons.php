<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
</head>
<body>
    <?php
        $blueBtn = "<button style='background-color: blue'>1</button>\n";
        $whiteBtn = "<button>0</button>\n";

        function makeBtnRow ($count, $btn) {
            for ($i = 0; $i < $count; ++$i) {
                echo $btn;
            }
        }

        makeBtnRow(5, $blueBtn);
        echo "</br>";

        for ($i = 0; $i < 3; ++$i) {
            echo $blueBtn;
            makeBtnRow(4, $whiteBtn);
            echo "</br>";
        }

        makeBtnRow(5, $blueBtn);
        echo "</br>";

        for ($i = 0; $i < 3; ++$i) {
            makeBtnRow(4, $whiteBtn);
            echo $blueBtn;
            echo "</br>";
        }

        makeBtnRow(5, $blueBtn);
        echo "</br>";
    ?>
</body>
</html>