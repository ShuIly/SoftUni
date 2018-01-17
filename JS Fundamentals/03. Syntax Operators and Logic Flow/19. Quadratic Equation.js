function getRoots(a, b, c) {
    let Discriminant = b * b - 4 * a * c;
    if (Discriminant < 0) {
        return "No";
    }

    let x1 = (- b - Math.sqrt(Discriminant)) / (2 * a);
    if (Discriminant > 0) {
        let x2 = (- b + Math.sqrt(Discriminant)) / (2 * a);
        return x1 + '\n' + x2;
    } else {
        return x1;
    }
}
