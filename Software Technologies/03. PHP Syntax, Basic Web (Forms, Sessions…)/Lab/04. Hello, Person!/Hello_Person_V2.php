<?php if (isset($_GET['person'])): ?>
    <?php
        $person = htmlspecialchars($_GET['person']);
        echo "Hello, $person";
    ?>
<?php else: ?>
    <form>
        <label for="person">Name:</label>
        <input type="text" name="person" id="person">
        <input type="submit">
    </form>
<?php endif; ?>