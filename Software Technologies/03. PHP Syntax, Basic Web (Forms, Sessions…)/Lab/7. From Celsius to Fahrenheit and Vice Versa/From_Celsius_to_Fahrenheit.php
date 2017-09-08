<?php
    $msgAfterCelsius = "";
    if (isset($_GET['cel']) ) {
        $cel = floatval($_GET['cel']);
        $fah = $cel * 1.8 + 32;
        $msgAfterCelsius = "$cel &deg;C = $fah &deg;F";;
    } else if (isset($_GET['fah'])) {
        $fah = floatval($_GET['fah']);
        $cel = ($fah - 32) / 1.8;
        $msgAfterCelsius = "$fah &deg;F = $cel &deg;C";
    }
?>
<form>
Celsius: <input type="text" name="cel" />
    <input type="submit" value="Convert">
    <?= $msgAfterCelsius ?>
</form>
<form>
    Fahrenheit: <input type="text" name="fah" />
    <input type="submit" value="Convert">
</form>