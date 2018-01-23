function parseData(employeeArr) {
    let regex = /^([A-Z][a-zA-Z]*) - ([1-9][0-9]*) - ([a-zA-Z0-9\- ]+)$/;
    let employeeData = [];

    for (let employeeStr of employeeArr) {
        let match = regex.exec(employeeStr);
        if (match !== null) {
            employeeData.push(`Name: ${match[1]}\nPosition: ${match[3]}\nSalary: ${match[2]}`);
        }
    }

    return employeeData.join('\n');
}
