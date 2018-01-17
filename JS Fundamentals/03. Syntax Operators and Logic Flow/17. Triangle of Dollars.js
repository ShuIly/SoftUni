function getDollarTriangle(n) {
    let result = '';
    for (let i = 1; i <= n; ++i) {
        result += '$'.repeat(i) + '\n';
    }

    return result;
}

