function getConeArea(radius, height) {
    let volume = Math.PI * radius * radius * height / 3;
    let area = Math.PI * radius * (radius + Math.sqrt(height * height + radius * radius));
    console.log(volume);
    console.log(area);
}