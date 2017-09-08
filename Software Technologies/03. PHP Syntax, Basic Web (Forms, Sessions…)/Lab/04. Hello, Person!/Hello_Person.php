<?php
    if (isset($_GET['person'])){
        $person = htmlspecialchars($_GET['person']);
        echo "Hello, $person!";
    } else {
?>
    <form>
        <label for="person">Name:</label>
        <input type="text" name="person" id="person">
        <input type="submit">
    </form>
<?php } ?>
