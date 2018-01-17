function getColorfulNumbers(count) {
    console.log("<ul>");
    for (let i = 1; i <= count; i++) {
        let color = i % 2 === 0 ? "blue" : "green";
        console.log(`\t<li><span style='color:${color}'>${i}</span></li>`)
    }
    console.log("<ul>");
}
